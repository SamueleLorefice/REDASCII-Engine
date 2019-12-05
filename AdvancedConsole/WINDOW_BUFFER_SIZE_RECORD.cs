using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedConsole {
    public struct WINDOW_BUFFER_SIZE_RECORD {
        public COORD dwSize;

        public WINDOW_BUFFER_SIZE_RECORD(short x, short y) {
            dwSize = new COORD();
            dwSize.X = x;
            dwSize.Y = y;
        }
    }
}
