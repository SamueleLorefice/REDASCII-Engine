using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace AdvancedConsole {
    [StructLayout(LayoutKind.Sequential)]
    public struct CONSOLE_HISTORY_INFO {
        ushort cbSize;
        ushort HistoryBufferSize;
        ushort NumberOfHistoryBuffers;
        uint dwFlags;
    }
}
