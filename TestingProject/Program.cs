using System;
using System.Diagnostics;
using AdvancedConsole;

namespace TestingProject {
    public class Program {

        private static void Main(string[] args) {
            uint outChars;
            IntPtr consoleHandle = Process.GetCurrentProcess().MainWindowHandle;
            CConsole.WriteConsole(consoleHandle, "HELLO C WORLD FROM C#", 21, out outChars, new IntPtr(0));
        }
    }
}