using System;

namespace REDASCII_Engine.Graphics {
    public struct AsciiBuffer {
        public AsciiPixel[,] Data { get; set; }
        public BufferPosition BufferPosition { get; set; }

        public AsciiBuffer( int left, int top, int width, int height) {
            Data = new AsciiPixel[width, height];
            BufferPosition = new BufferPosition(top, left, width, height);
        }
    }
}