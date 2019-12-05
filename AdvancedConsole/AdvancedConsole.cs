using System;
using System.Runtime.InteropServices;

namespace AdvancedConsole {
    public class AdvancedConsole {
        [DllImport("Kernel32.dll", EntryPoint = "WriteConsoleOutputW")]
        public static extern void WriteBufferOutput(IntPtr consoleOutput, char[,] data, COORD bufferSize, COORD startCoord, out SMALL_RECT WriteRegion);

        [DllImport("Kernel32.dll", EntryPoint = "ReadConsole")]
        public static extern void ReadConsole();
    }
}
