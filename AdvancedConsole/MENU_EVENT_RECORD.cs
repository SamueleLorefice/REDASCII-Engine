using System.Runtime.InteropServices;

namespace AdvancedConsole {

    [StructLayout(LayoutKind.Sequential)]
    public struct MENU_EVENT_RECORD {
        public uint dwCommandId;
    }
}