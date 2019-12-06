using System;
using System.Runtime.InteropServices;

namespace AdvancedConsole {

    //CHAR_INFO struct, which was a union in the old days
    // so we want to use LayoutKind.Explicit to mimic it as closely
    // as we can
    [StructLayout(LayoutKind.Explicit)]
    public struct CHAR_INFO {

        [FieldOffset(0)]
        public char UnicodeChar;

        [FieldOffset(0)]
        public char AsciiChar;

        [FieldOffset(2)] //2 bytes seems to work properly
        public UInt16 Attributes;
    }
}