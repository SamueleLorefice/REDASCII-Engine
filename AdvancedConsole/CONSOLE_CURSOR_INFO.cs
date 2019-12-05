using System.Runtime.InteropServices;

namespace AdvancedConsole {

    [StructLayout(LayoutKind.Sequential)]
    public struct CONSOLE_CURSOR_INFO {
        private uint Size;
        private bool Visible;
    }
}