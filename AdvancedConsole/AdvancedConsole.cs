using System;
using System.Runtime.InteropServices;
using System.Text;

namespace AdvancedConsole {

    public class AdvancedConsole {

        [DllImport("kernel32", SetLastError = true)]
        private static extern bool AddConsoleAlias(
            string Source,
            string Target,
            string ExeName
            );

        [DllImport("kernel32", SetLastError = true)]
        private static extern bool AllocConsole();

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool AttachConsole(
            uint dwProcessId
            );

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern IntPtr CreateConsoleScreenBuffer(
            uint dwDesiredAccess,
            uint dwShareMode,
            IntPtr lpSecurityAttributes,
            uint dwFlags,
            IntPtr lpScreenBufferData
            );

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool FillConsoleOutputAttribute(
            IntPtr hConsoleOutput,
            ushort wAttribute,
            uint nLength,
            COORD dwWriteCoord,
            out uint lpNumberOfAttrsWritten
            );

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool FillConsoleOutputCharacter(
            IntPtr hConsoleOutput,
            char cCharacter,
            uint nLength,
            COORD dwWriteCoord,
            out uint lpNumberOfCharsWritten
            );

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool FlushConsoleInputBuffer(
            IntPtr hConsoleInput
            );

        [DllImport("kernel32.dll", SetLastError = true, ExactSpelling = true)]
        private static extern bool FreeConsole();

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool GenerateConsoleCtrlEvent(
            uint dwCtrlEvent,
            uint dwProcessGroupId
            );

        [DllImport("kernel32", SetLastError = true)]
        private static extern bool GetConsoleAlias(
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
        private static extern uint GetConsoleAliasesLength(
            string ExeName
            );

        [DllImport("kernel32", SetLastError = true)]
        private static extern uint GetConsoleAliasExes(
            out StringBuilder ExeNameBuffer,
            uint ExeNameBufferLength
            );

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern uint GetConsoleAliasExesLength();

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern uint GetConsoleCP();

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool GetConsoleCursorInfo(
            IntPtr hConsoleOutput,
            out CONSOLE_CURSOR_INFO lpConsoleCursorInfo
            );

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool GetConsoleDisplayMode(
            out uint ModeFlags
            );

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern COORD GetConsoleFontSize(
            IntPtr hConsoleOutput,
            Int32 nFont
            );

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool GetConsoleHistoryInfo(
            out CONSOLE_HISTORY_INFO ConsoleHistoryInfo
            );

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool GetConsoleMode(
            IntPtr hConsoleHandle,
            out uint lpMode
            );

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern uint GetConsoleOriginalTitle(
            out StringBuilder ConsoleTitle,
            uint Size
            );

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern uint GetConsoleOutputCP();

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern uint GetConsoleProcessList(
            out uint[] ProcessList,
            uint ProcessCount
            );

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool GetConsoleScreenBufferInfo(
            IntPtr hConsoleOutput,
            out CONSOLE_SCREEN_BUFFER_INFO lpConsoleScreenBufferInfo
            );

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool GetConsoleScreenBufferInfoEx(
            IntPtr hConsoleOutput,
            ref CONSOLE_SCREEN_BUFFER_INFO_EX ConsoleScreenBufferInfo
            );

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool GetConsoleSelectionInfo(
            CONSOLE_SELECTION_INFO ConsoleSelectionInfo
            );

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern uint GetConsoleTitle(
            [Out] StringBuilder lpConsoleTitle,
            uint nSize
            );

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern IntPtr GetConsoleWindow();

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool GetCurrentConsoleFont(
            IntPtr hConsoleOutput,
            bool bMaximumWindow,
            out CONSOLE_FONT_INFO lpConsoleCurrentFont
            );

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool GetCurrentConsoleFontEx(
            IntPtr ConsoleOutput,
            bool MaximumWindow,
            out CONSOLE_FONT_INFO_EX ConsoleCurrentFont
            );

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern COORD GetLargestConsoleWindowSize(
            IntPtr hConsoleOutput
            );

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool GetNumberOfConsoleInputEvents(
            IntPtr hConsoleInput,
            out uint lpcNumberOfEvents
            );

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool GetNumberOfConsoleMouseButtons(
            ref uint lpNumberOfMouseButtons
            );

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern IntPtr GetStdHandle(
            int nStdHandle
            );

        private delegate bool ConsoleCtrlDelegate(CtrlTypes CtrlType);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool PeekConsoleInput(
            IntPtr hConsoleInput,
            [Out] INPUT_RECORD[] lpBuffer,
            uint nLength,
            out uint lpNumberOfEventsRead
            );

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool ReadConsole(
            IntPtr hConsoleInput,
            [Out] StringBuilder lpBuffer,
            uint nNumberOfCharsToRead,
            out uint lpNumberOfCharsRead,
            IntPtr lpReserved
            );

        [DllImport("kernel32.dll", EntryPoint = "ReadConsoleInputW", CharSet = CharSet.Unicode)]
        private static extern bool ReadConsoleInput(
            IntPtr hConsoleInput,
            [Out] INPUT_RECORD[] lpBuffer,
            uint nLength,
            out uint lpNumberOfEventsRead
            );

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool ReadConsoleOutput(
            IntPtr hConsoleOutput,
            [Out] CHAR_INFO[] lpBuffer,
            COORD dwBufferSize,
            COORD dwBufferCoord,
            ref SMALL_RECT lpReadRegion
            );

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool ReadConsoleOutputAttribute(
            IntPtr hConsoleOutput,
            [Out] ushort[] lpAttribute,
            uint nLength,
            COORD dwReadCoord,
            out uint lpNumberOfAttrsRead
            );

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool ReadConsoleOutputCharacter(
            IntPtr hConsoleOutput,
            [Out] StringBuilder lpCharacter,
            uint nLength,
            COORD dwReadCoord,
            out uint lpNumberOfCharsRead
            );

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool ScrollConsoleScreenBuffer(
            IntPtr hConsoleOutput,
           [In] ref SMALL_RECT lpScrollRectangle,
            IntPtr lpClipRectangle,
           COORD dwDestinationOrigin,
            [In] ref CHAR_INFO lpFill
            );

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool SetConsoleActiveScreenBuffer(
            IntPtr hConsoleOutput
            );

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool SetConsoleCP(
            uint wCodePageID
            );

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool SetConsoleCtrlHandler(
            ConsoleCtrlDelegate HandlerRoutine,
            bool Add
            );

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool SetConsoleCursorInfo(
            IntPtr hConsoleOutput,
            [In] ref CONSOLE_CURSOR_INFO lpConsoleCursorInfo
            );

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool SetConsoleCursorPosition(
            IntPtr hConsoleOutput,
           COORD dwCursorPosition
            );

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool SetConsoleDisplayMode(
            IntPtr ConsoleOutput,
            uint Flags,
            out COORD NewScreenBufferDimensions
            );

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool SetConsoleHistoryInfo(
            CONSOLE_HISTORY_INFO ConsoleHistoryInfo
            );

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool SetConsoleMode(
            IntPtr hConsoleHandle,
            uint dwMode
            );

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool SetConsoleOutputCP(
            uint wCodePageID
            );

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool SetConsoleScreenBufferInfoEx(
            IntPtr ConsoleOutput,
            CONSOLE_SCREEN_BUFFER_INFO_EX ConsoleScreenBufferInfoEx
            );

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool SetConsoleScreenBufferSize(
            IntPtr hConsoleOutput,
            COORD dwSize
            );

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool SetConsoleTextAttribute(
            IntPtr hConsoleOutput,
           ushort wAttributes
            );

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool SetConsoleTitle(
            string lpConsoleTitle
            );

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool SetConsoleWindowInfo(
            IntPtr hConsoleOutput,
            bool bAbsolute,
            [In] ref SMALL_RECT lpConsoleWindow
            );

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool SetCurrentConsoleFontEx(
            IntPtr ConsoleOutput,
            bool MaximumWindow,
            CONSOLE_FONT_INFO_EX ConsoleCurrentFontEx
            );

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool SetStdHandle(
            uint nStdHandle,
            IntPtr hHandle
            );

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool WriteConsole(
            IntPtr hConsoleOutput,
            string lpBuffer,
            uint nNumberOfCharsToWrite,
            out uint lpNumberOfCharsWritten,
            IntPtr lpReserved
            );

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool WriteConsoleInput(
            IntPtr hConsoleInput,
            INPUT_RECORD[] lpBuffer,
            uint nLength,
            out uint lpNumberOfEventsWritten
            );

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool WriteConsoleOutput(
            IntPtr hConsoleOutput,
            CHAR_INFO[] lpBuffer,
            COORD dwBufferSize,
            COORD dwBufferCoord,
            ref SMALL_RECT lpWriteRegion
            );

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool WriteConsoleOutputAttribute(
            IntPtr hConsoleOutput,
            ushort[] lpAttribute,
            uint nLength,
            COORD dwWriteCoord,
            out uint lpNumberOfAttrsWritten
            );

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool WriteConsoleOutputCharacter(
            IntPtr hConsoleOutput,
            string lpCharacter,
            uint nLength,
            COORD dwWriteCoord,
            out uint lpNumberOfCharsWritten
            );
    }
}