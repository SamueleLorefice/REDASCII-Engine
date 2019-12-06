using System;
using System.Diagnostics;
using AdvancedConsole;

namespace TestingProject {
    public class Program {

        private static void Main(string[] args) {
            uint outChars;
            IntPtr consoleHandle = Process.GetCurrentProcess().MainWindowHandle;
            CConsole.WriteConsole(consoleHandle, "HELLO C WORLD FROM C#", 21, out outChars, new IntPtr(0));
            Console.WriteLine("OutputWrite testing:");
            CHAR_INFO[,] BufferData = new CHAR_INFO[8, 2];
            CHAR_INFO a = new CHAR_INFO { UnicodeChar = 'C' };
            SMALL_RECT writeBounds = new SMALL_RECT { Top = 3, Left = 2, Bottom = 5, Right = 10 };
            CConsole.WriteConsoleOutput(consoleHandle, BufferData, new COORD { X = 8, Y = 2 }, new COORD { X = 2, Y = 4 }, ref writeBounds);


        }
    }
}