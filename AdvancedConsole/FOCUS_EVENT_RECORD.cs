using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace AdvancedConsole {
    [StructLayout(LayoutKind.Sequential)]
    public struct FOCUS_EVENT_RECORD {
        public uint bSetFocus;
    }
}
