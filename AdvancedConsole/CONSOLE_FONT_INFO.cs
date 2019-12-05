using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace AdvancedConsole {
    [StructLayout(LayoutKind.Sequential)]
    public struct CONSOLE_FONT_INFO {
        public int nFont;
        public COORD dwFontSize;
    }
}
