using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace AdvancedConsole {
    [StructLayout(LayoutKind.Sequential)]
    public struct CONSOLE_CURSOR_INFO {
        uint Size;
        bool Visible;
    }
}
