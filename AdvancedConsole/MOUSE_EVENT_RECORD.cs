using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace AdvancedConsole {
    [StructLayout(LayoutKind.Sequential)]
    public struct MOUSE_EVENT_RECORD {
        public COORD dwMousePosition;
        public uint dwButtonState;
        public uint dwControlKeyState;
        public uint dwEventFlags;
    }
}
