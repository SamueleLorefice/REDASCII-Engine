namespace REDASCII_Engine.Graphics {

    public interface IRenderable {
        public Transform Transform { get; set; }
        public AsciiPixel[,] Data { get; set; }
    }
}