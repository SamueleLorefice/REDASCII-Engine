using System;
using System.Collections.Generic;
using System.Text;

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
