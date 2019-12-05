using System.Runtime.InteropServices;

namespace AdvancedConsole {

    [StructLayout(LayoutKind.Sequential)]
    public struct FOCUS_EVENT_RECORD {
        public uint bSetFocus;
    }
}