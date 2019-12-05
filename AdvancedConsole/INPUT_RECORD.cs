using System.Runtime.InteropServices;

namespace AdvancedConsole {

    [StructLayout(LayoutKind.Explicit)]
    public struct INPUT_RECORD {

        [FieldOffset(0)]
        public ushort EventType;

        [FieldOffset(4)]
        public KEY_EVENT_RECORD KeyEvent;

        [FieldOffset(4)]
        public MOUSE_EVENT_RECORD MouseEvent;

        [FieldOffset(4)]
        public WINDOW_BUFFER_SIZE_RECORD WindowBufferSizeEvent;

        [FieldOffset(4)]
        public MENU_EVENT_RECORD MenuEvent;

        [FieldOffset(4)]
        public FOCUS_EVENT_RECORD FocusEvent;
    }
}