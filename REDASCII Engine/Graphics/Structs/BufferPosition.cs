namespace REDASCII_Engine.Graphics {

    public struct BufferPosition {
        public int Top { get; set; }
        public int Left { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public BufferPosition(int top, int left, int width, int height) {
            Top = top;
            Left = left;
            Width = width;
            Height = height;
        }
    }
}