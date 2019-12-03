using System;

namespace REDASCII_Engine.Graphics {
    public struct AsciiBuffer {
        public AsciiPixel[,] Data { get; set; }
        public int StartPosition;

        public AsciiBuffer(int X, int Y, int startPosition) {
            Data = new AsciiPixel[X, Y];
            StartPosition = startPosition;
        }
    }
}