using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace AdvancedConsole {
    //CHAR_INFO struct, which was a union in the old days
    // so we want to use LayoutKind.Explicit to mimic it as closely
    // as we can
    [StructLayout(LayoutKind.Explicit)]
    public struct CHAR_INFO {
        [FieldOffset(0)]
        char UnicodeChar;
        [FieldOffset(0)]
        char AsciiChar;
        [FieldOffset(2)] //2 bytes seems to work properly
        UInt16 Attributes;
    }
}
