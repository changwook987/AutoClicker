
using AutoClicker.Utils;
using Timer = System.Timers.Timer;
using MouseCursor = System.Windows.Forms.Cursor;
using ErapsedEventArgs = System.Timers.ElapsedEventArgs;

namespace AutoClicker.Views
{
    public partial class Main : Form
    {
        private readonly KeyHandler keyHandler;
        private readonly Timer timer;

        public Main()
        {
            InitializeComponent();
            keyHandler = new KeyHandler(Keys.F3, this);
            keyHandler.Register();
            timer = new Timer();
            timer.Elapsed += OnTimerErapsed;
        }

        bool clicking = false;
        int dwFlag = 0;

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == Constants.WM_HOTKEY_MSG_ID)
            {
                clicking = !clicking;
                SetClicking(clicking);
            }
            base.WndProc(ref m);
        }

        private void SetClicking(bool flag)
        {
            if (flag)
            {
                label.Text = "CLICKING!!!!!!!";
                timer.Interval = 1;
                timer.Start();
            }
            else
            {
                label.Text = "WAITING........";
                timer.Stop();
            }

        }

        private void OnTimerErapsed(object? sender, ErapsedEventArgs e)
        {
            if (!clicking) return;
            for (int i = 0; i < 5; i++)
            {
                var pos = MouseCursor.Position;
                User32ApiUtils.SetCursorPosition(
                    pos.X,
                    pos.Y
                );
                User32ApiUtils.ExecuteMouseEvent(dwFlag, pos.X, pos.Y, 0, 0);
            }
        }
    }
}