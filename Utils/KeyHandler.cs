namespace AutoClicker.Utils
{
    public class KeyHandler
    {
        private int key;
        private IntPtr hWnd;
        private int id;

        public KeyHandler(Keys key, Form form)
        {
            this.key = (int)key;
            this.hWnd = form.Handle;
            this.id = GetHashCode();
        }

        public override int GetHashCode()
        {
            return key ^ hWnd.ToInt32();
        }

        public bool Register()
        {
            return User32ApiUtils.RegisterHotKey(hWnd, id, 0, key);
        }

        public bool Unregister()
        {
            return User32ApiUtils.UnregisterHotKey(hWnd, id);
        }
    }
}