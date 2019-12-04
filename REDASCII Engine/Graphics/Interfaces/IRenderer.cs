using System;
using System.Collections.Generic;
using System.Text;

namespace REDASCII_Engine.Graphics {
    public interface IRenderer : ISystem {
        public int TargetFPS { get; set; }
        public AsciiBuffer[] Buffers { get; set; }
        public void DrawBuffer(int bufferIndex);
        public void SwapBuffer(int topBuffer);

    }
}
