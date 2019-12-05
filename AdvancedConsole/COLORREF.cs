using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace AdvancedConsole {
    [StructLayout(LayoutKind.Sequential)]
    public struct COLORREF {
        public uint ColorDWORD;

        public COLORREF(System.Drawing.Color color) {
            ColorDWORD = (uint)color.R + (((uint)color.G) << 8) + (((uint)color.B) << 16);
        }

        public System.Drawing.Color GetColor() {
            return System.Drawing.Color.FromArgb((int)(0x000000FFU & ColorDWORD),
               (int)(0x0000FF00U & ColorDWORD) >> 8, (int)(0x00FF0000U & ColorDWORD) >> 16);
        }

        public void SetColor(System.Drawing.Color color) {
            ColorDWORD = (uint)color.R + (((uint)color.G) << 8) + (((uint)color.B) << 16);
        }
    }
}
