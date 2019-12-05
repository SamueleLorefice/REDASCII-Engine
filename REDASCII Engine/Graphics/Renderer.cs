using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using AdvancedConsole;

namespace REDASCII_Engine.Graphics {
    class Renderer : IRenderer {
        public int TargetFPS { get; set; }
        public AsciiBuffer[] Buffers { get; set; }

        public List<IRenderable> RenderObjects;

        bool IsStopRequested = false;

        public Renderer(int Top, int Left, int Height, int Width) {
            Buffers = new AsciiBuffer[2] { 
                new AsciiBuffer(Left, Top, Width, Height),//4 rows spacing 
                new AsciiBuffer(Left, Top*2, Width, Height)};
            RenderObjects = new List<IRenderable>();
        }

        public void DrawBuffer(int bufferIndex) {
            var bufferPos = Buffers[bufferIndex].BufferPosition;//cache of the buffer position
            //creates a cache of the buffer that needs to be written
            AsciiPixel[,] tempBuffer = new AsciiPixel[Buffers[0].Data.GetLength(0), Buffers[0].Data.GetLength(1)];

            RenderObjects.Sort((x, y) => y.Transform.Z.CompareTo(x.Transform.Z));//sorting the list to the Z in descending order
            foreach (IRenderable renderable in RenderObjects) {
                Transform localPosition = renderable.Transform;
                for (int x = 0; x < renderable.Data.GetLength(1); x++) {//each line
                    for (int y = 0; y < renderable.Data.GetLength(0); y++) {
                        if (renderable.Data[x, y].Data != '\0') {
                            tempBuffer[x + localPosition.X, y + localPosition.Y].Data = renderable.Data[x, y].Data;
                            tempBuffer[x + localPosition.X, y + localPosition.Y].Color = renderable.Data[x, y].Color;
                        }
                    }
                }
            }
            Buffers[bufferIndex].Data = tempBuffer;
            //separating colors
            var renderPasses = new Dictionary<ConsoleColor, char[,]>();
            for (int x = 0; x < tempBuffer.GetLength(0); x++) {
                for (int y = 0; y < tempBuffer.GetLength(1); y++) {
                    if(renderPasses.ContainsKey(tempBuffer[x, y].Color)){//check if the color of the pixel already have a buffer
                        renderPasses[tempBuffer[x, y].Color][x, y] = tempBuffer[x, y].Data;//add the pixel at the right position
                    } else {
                        renderPasses.Add(tempBuffer[x, y].Color, new char[tempBuffer.GetLength(0), tempBuffer.GetLength(1)]);//add the new buffer
                        renderPasses[tempBuffer[x, y].Color][x, y] = tempBuffer[x, y].Data;//then add the pixel
                    }
                }
            }
            //gets the console handle
            IntPtr handle = Process.GetCurrentProcess().MainWindowHandle;

            //https://docs.microsoft.com/en-us/windows/console/writeconsoleoutput
            
            //finally write the buffer, one color at the time:
            foreach (var colorBuffer in renderPasses) {
                //WriteBufferOutput(handle, colorBuffer.Value, new COORD() { });
            }
        }

        public void Run() {
            while (!IsStopRequested) {
                DrawBuffer(1);
                SwapBuffer(1);
                DrawBuffer(0);
                SwapBuffer(0);
            }
        }

        public void Stop() {
            IsStopRequested = true;
        }

        public void SwapBuffer(int topBuffer) {
            Console.MoveBufferArea(
                Buffers[topBuffer].BufferPosition.Left,
                Buffers[topBuffer].BufferPosition.Top,
                Buffers[topBuffer].BufferPosition.Width,
                Buffers[topBuffer].BufferPosition.Height,
                Console.WindowLeft,
                Console.WindowTop
            );

        }
    }
}
