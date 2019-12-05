using System.Runtime.InteropServices;

namespace AdvancedConsole {

    [StructLayout(LayoutKind.Sequential)]
    public struct CONSOLE_FONT_INFO {
        public int nFont;
        public COORD dwFontSize;
    }
}