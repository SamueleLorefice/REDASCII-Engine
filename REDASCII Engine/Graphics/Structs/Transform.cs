using System;
using System.Collections.Generic;
using System.Text;

namespace REDASCII_Engine.Graphics {
    public struct Transform {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        public Rotation Rotation { get; set; }
    }
}
