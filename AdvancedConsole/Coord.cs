using System.Runtime.InteropServices;

namespace AdvancedConsole {

    [StructLayout(LayoutKind.Sequential)]
    public struct COORD {
        public short X;
        public short Y;
    }
}