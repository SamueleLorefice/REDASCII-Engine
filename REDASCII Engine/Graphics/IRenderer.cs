using System;
using System.Collections.Generic;
using System.Text;

namespace REDASCII_Engine.Graphics {
    public interface IRenderer : ISystem {
        public int TargetFPS { get; set; }
        public void DrawBuffer();
        public void SwapBuffer();

    }
}
