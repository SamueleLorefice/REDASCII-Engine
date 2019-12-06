using System;
using System.Runtime.InteropServices;
using System.Text;

namespace AdvancedConsole {

    public class CConsole {

        [DllImport("kernel32", SetLastError = true)]
        public static extern bool AddConsoleAlias(
            string Source,
            string Target,
            string ExeName
            );

        [DllImport("kernel32", SetLastError = true)]
        public static extern bool AllocConsole();

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool AttachConsole(
            uint dwProcessId
            );

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern IntPtr CreateConsoleScreenBuffer(
            uint dwDesiredAccess,
            uint dwShareMode,
            IntPtr lpSecurityAttributes,
            uint dwFlags,
            IntPtr lpScreenBufferData
            );

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool FillConsoleOutputAttribute(
            IntPtr hConsoleOutput,
            ushort wAttribute,
            uint nLength,
            COORD dwWriteCoord,
            out uint lpNumberOfAttrsWritten
            );

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool FillConsoleOutputCharacter(
            IntPtr hConsoleOutput,
            char cCharacter,
            uint nLength,
            COORD dwWriteCoord,
            out uint lpNumberOfCharsWritten
            );

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool FlushConsoleInputBuffer(
            IntPtr hConsoleInput
            );

        [DllImport("kernel32.dll", SetLastError = true, ExactSpelling = true)]
        public static extern bool FreeConsole();

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool GenerateConsoleCtrlEvent(
            uint dwCtrlEvent,
            uint dwProcessGroupId
            );

        [DllImport("kernel32", SetLastError = true)]
        public static extern bool GetConsoleAlias(
            string Source,
            out StringBuilder TargetBuffer,
            uint TargetBufferLength,
            string ExeName
            );

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern uint GetConsoleAliases(
            StringBuilder[] lpTargetBuffer,
            uint targetBufferLength,
            string lpExeName
            );

        [DllImport("kernel32", SetLastError = true)]
        public static extern uint GetConsoleAliasesLength(
            string ExeName
            );

        [DllImport("kernel32", SetLastError = true)]
        public static extern uint GetConsoleAliasExes(
            out StringBuilder ExeNameBuffer,
            uint ExeNameBufferLength
            );

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern uint GetConsoleAliasExesLength();

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern uint GetConsoleCP();

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool GetConsoleCursorInfo(
            IntPtr hConsoleOutput,
            out CONSOLE_CURSOR_INFO lpConsoleCursorInfo
            );

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool GetConsoleDisplayMode(
            out uint ModeFlags
            );

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern COORD GetConsoleFontSize(
            IntPtr hConsoleOutput,
            Int32 nFont
            );

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool GetConsoleHistoryInfo(
            out CONSOLE_HISTORY_INFO ConsoleHistoryInfo
            );

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool GetConsoleMode(
            IntPtr hConsoleHandle,
            out uint lpMode
            );

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern uint GetConsoleOriginalTitle(
            out StringBuilder ConsoleTitle,
            uint Size
            );

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern uint GetConsoleOutputCP();

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern uint GetConsoleProcessList(
            out uint[] ProcessList,
            uint ProcessCount
            );

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool GetConsoleScreenBufferInfo(
            IntPtr hConsoleOutput,
            out CONSOLE_SCREEN_BUFFER_INFO lpConsoleScreenBufferInfo
            );

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool GetConsoleScreenBufferInfoEx(
            IntPtr hConsoleOutput,
            ref CONSOLE_SCREEN_BUFFER_INFO_EX ConsoleScreenBufferInfo
            );

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool GetConsoleSelectionInfo(
            CONSOLE_SELECTION_INFO ConsoleSelectionInfo
            );

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern uint GetConsoleTitle(
            [Out] StringBuilder lpConsoleTitle,
            uint nSize
            );

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern IntPtr GetConsoleWindow();

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool GetCurrentConsoleFont(
            IntPtr hConsoleOutput,
            bool bMaximumWindow,
            out CONSOLE_FONT_INFO lpConsoleCurrentFont
            );

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool GetCurrentConsoleFontEx(
            IntPtr ConsoleOutput,
            bool MaximumWindow,
            out CONSOLE_FONT_INFO_EX ConsoleCurrentFont
            );

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern COORD GetLargestConsoleWindowSize(
            IntPtr hConsoleOutput
            );

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool GetNumberOfConsoleInputEvents(
            IntPtr hConsoleInput,
            out uint lpcNumberOfEvents
            );

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool GetNumberOfConsoleMouseButtons(
            ref uint lpNumberOfMouseButtons
            );

        [Obsolete("You can use Process.GetCurrentProcess().MainWindowHandle; for it.")]
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern IntPtr GetStdHandle(
            int nStdHandle
            );

        public delegate bool ConsoleCtrlDelegate(CtrlTypes CtrlType);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool PeekConsoleInput(
            IntPtr hConsoleInput,
            [Out] INPUT_RECORD[] lpBuffer,
            uint nLength,
            out uint lpNumberOfEventsRead
            );

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool ReadConsole(
            IntPtr hConsoleInput,
            [Out] StringBuilder lpBuffer,
            uint nNumberOfCharsToRead,
            out uint lpNumberOfCharsRead,
            IntPtr lpReserved
            );

        [DllImport("kernel32.dll", EntryPoint = "ReadConsoleInputW", CharSet = CharSet.Unicode)]
        public static extern bool ReadConsoleInput(
            IntPtr hConsoleInput,
            [Out] INPUT_RECORD[] lpBuffer,
            uint nLength,
            out uint lpNumberOfEventsRead
            );

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool ReadConsoleOutput(
            IntPtr hConsoleOutput,
            [Out] CHAR_INFO[] lpBuffer,
            COORD dwBufferSize,
            COORD dwBufferCoord,
            ref SMALL_RECT lpReadRegion
            );

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool ReadConsoleOutputAttribute(
            IntPtr hConsoleOutput,
            [Out] ushort[] lpAttribute,
            uint nLength,
            COORD dwReadCoord,
            out uint lpNumberOfAttrsRead
            );

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool ReadConsoleOutputCharacter(
            IntPtr hConsoleOutput,
            [Out] StringBuilder lpCharacter,
            uint nLength,
            COORD dwReadCoord,
            out uint lpNumberOfCharsRead
            );

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool ScrollConsoleScreenBuffer(
            IntPtr hConsoleOutput,
           [In] ref SMALL_RECT lpScrollRectangle,
            IntPtr lpClipRectangle,
           COORD dwDestinationOrigin,
            [In] ref CHAR_INFO lpFill
            );

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool SetConsoleActiveScreenBuffer(
            IntPtr hConsoleOutput
            );

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool SetConsoleCP(
            uint wCodePageID
            );

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool SetConsoleCtrlHandler(
            ConsoleCtrlDelegate HandlerRoutine,
            bool Add
            );

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool SetConsoleCursorInfo(
            IntPtr hConsoleOutput,
            [In] ref CONSOLE_CURSOR_INFO lpConsoleCursorInfo
            );

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool SetConsoleCursorPosition(
            IntPtr hConsoleOutput,
           COORD dwCursorPosition
            );

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool SetConsoleDisplayMode(
            IntPtr ConsoleOutput,
            uint Flags,
            out COORD NewScreenBufferDimensions
            );

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool SetConsoleHistoryInfo(
            CONSOLE_HISTORY_INFO ConsoleHistoryInfo
            );

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool SetConsoleMode(
            IntPtr hConsoleHandle,
            uint dwMode
            );

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool SetConsoleOutputCP(
            uint wCodePageID
            );

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool SetConsoleScreenBufferInfoEx(
            IntPtr ConsoleOutput,
            CONSOLE_SCREEN_BUFFER_INFO_EX ConsoleScreenBufferInfoEx
            );

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool SetConsoleScreenBufferSize(
            IntPtr hConsoleOutput,
            COORD dwSize
            );

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool SetConsoleTextAttribute(
            IntPtr hConsoleOutput,
           ushort wAttributes
            );

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool SetConsoleTitle(
            string lpConsoleTitle
            );

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool SetConsoleWindowInfo(
            IntPtr hConsoleOutput,
            bool bAbsolute,
            [In] ref SMALL_RECT lpConsoleWindow
            );

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool SetCurrentConsoleFontEx(
            IntPtr ConsoleOutput,
            bool MaximumWindow,
            CONSOLE_FONT_INFO_EX ConsoleCurrentFontEx
            );

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool SetStdHandle(
            uint nStdHandle,
            IntPtr hHandle
            );

        /// <summary>
        /// Writes a character string to a console screen buffer beginning at the current cursor location.
        /// </summary>
        /// <param name="hConsoleOutput">A handle to the console screen buffer. The handle must have the GENERIC_WRITE access right.</param>
        /// <param name="lpBuffer">String of characters to write</param>
        /// <param name="nNumberOfCharsToWrite">Number of characters to write, if the total size of the specified number of characters exceeds the available heap, the function fails with ERROR_NOT_ENOUGH_MEMORY.</param>
        /// <param name="lpNumberOfCharsWritten">Number of characters actually written.</param>
        /// <param name="lpReserved">Reserved; must be IntPtr(0)</param>
        /// <returns>If the function succeeds, the return value is nonzero. If the function fails, the return value is zero.</returns>
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool WriteConsole(
            IntPtr hConsoleOutput,
            string lpBuffer,
            uint nNumberOfCharsToWrite,
            out uint lpNumberOfCharsWritten,
            IntPtr lpReserved
            );

        /// <summary>
        /// Writes data directly to the console input buffer. NOTE: Won't be using this, and won't test it. You are welcome to send a pull request if you want this method and related structs to have documentation.
        /// </summary>
        /// <param name="hConsoleInput">A handle to the console input buffer. The handle must have the GENERIC_WRITE access right.</param>
        /// <param name="lpBuffer">Array of <see cref="INPUT_RECORD"/> structures that contain data to be written to the input buffer</param>
        /// <param name="nLength">The number of input records to be written.</param>
        /// <param name="lpNumberOfEventsWritten">Variable that receives the number of input records actually written.</param>
        /// <returns>If the function succeeds, the return value is nonzero. If the function fails, the return value is zero.</returns>
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool WriteConsoleInput(
            IntPtr hConsoleInput,
            INPUT_RECORD[] lpBuffer,
            uint nLength,
            out uint lpNumberOfEventsWritten
            );

        /// <summary>
        /// Writes character and color attribute data to a specified rectangular block of character cells in a console screen buffer. The data to be written is taken from a correspondingly sized rectangular block at a specified location in the source buffer.
        /// </summary>
        /// <param name="hConsoleOutput">A handle to the console screen buffer. The handle must have the GENERIC_WRITE access right.</param>
        /// <param name="lpBuffer">The data to be written to the console screen buffer.</param>
        /// <param name="dwBufferSize">The size of the buffer pointed to by the lpBuffer parameter.</param>
        /// <param name="dwBufferCoord">The coordinates of the upper-left cell in the buffer pointed to by the lpBuffer parameter.</param>
        /// <param name="lpWriteRegion">On input, the structure members specify the upper-left and lower-right coordinates of the console screen buffer rectangle to write to. On output, the structure members specify the actual rectangle that was used.</param>
        /// <returns>If the function succeeds, the return value is nonzero. If the function fails, the return value is zero.</returns>
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool WriteConsoleOutput(
            IntPtr hConsoleOutput,
            CHAR_INFO[,] lpBuffer,
            COORD dwBufferSize,
            COORD dwBufferCoord,
            ref SMALL_RECT lpWriteRegion
            );

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool WriteConsoleOutputAttribute(
            IntPtr hConsoleOutput,
            ushort[] lpAttribute,
            uint nLength,
            COORD dwWriteCoord,
            out uint lpNumberOfAttrsWritten
            );

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool WriteConsoleOutputCharacter(
            IntPtr hConsoleOutput,
            string lpCharacter,
            uint nLength,
            COORD dwWriteCoord,
            out uint lpNumberOfCharsWritten
            );
    }
}