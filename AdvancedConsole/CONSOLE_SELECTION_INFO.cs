using System.Runtime.InteropServices;

namespace AdvancedConsole {

    [StructLayout(LayoutKind.Sequential)]
    public struct CONSOLE_SELECTION_INFO {
        private uint Flags;
        private COORD SelectionAnchor;
        private SMALL_RECT Selection;

        // Flags values:
        private const uint CONSOLE_MOUSE_DOWN = 0x0008; // Mouse is down

        private const uint CONSOLE_MOUSE_SELECTION = 0x0004; //Selecting with the mouse
        private const uint CONSOLE_NO_SELECTION = 0x0000; //No selection
        private const uint CONSOLE_SELECTION_IN_PROGRESS = 0x0001; //Selection has begun
        private const uint CONSOLE_SELECTION_NOT_EMPTY = 0x0002; //Selection rectangle is not empty
    }
}