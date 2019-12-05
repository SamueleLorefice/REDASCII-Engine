using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace AdvancedConsole {
    [StructLayout(LayoutKind.Sequential)]
    public struct SMALL_RECT {
        public UInt16 Left;
        public UInt16 Top;
        public UInt16 Right;
        public UInt16 Bottom;
    }
}
