namespace AdvancedConsole {

    // Enumerated type for the control messages sent to the handler routine
    internal enum CtrlTypes : uint {
        CTRL_C_EVENT = 0,
        CTRL_BREAK_EVENT,
        CTRL_CLOSE_EVENT,
        CTRL_LOGOFF_EVENT = 5,
        CTRL_SHUTDOWN_EVENT
    }
}