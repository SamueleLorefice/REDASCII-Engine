using System.Runtime.InteropServices;

namespace AdvancedConsole {

    [StructLayout(LayoutKind.Sequential)]
    public struct CONSOLE_HISTORY_INFO {
        private ushort cbSize;
        private ushort HistoryBufferSize;
        private ushort NumberOfHistoryBuffers;
        private uint dwFlags;
    }
}