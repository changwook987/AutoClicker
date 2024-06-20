using System.Runtime.InteropServices;

namespace AutoClicker.Utils
{
    public partial class User32ApiUtils
    {
        [LibraryImport("user32.dll", EntryPoint = "SetCursorPos")]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static partial bool SetCursorPosition(int x, int y);

        [LibraryImport("user32.dll", EntryPoint = "mouse_event")]
        internal static partial void ExecuteMouseEvent(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        [LibraryImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static partial bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);

        [LibraryImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static partial bool UnregisterHotKey(IntPtr hWnd, int id);
    }
}
