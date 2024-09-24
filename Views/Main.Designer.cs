using AutoClicker.Utils;

namespace AutoClicker.Views
{
    partial class Main
    {
        private System.ComponentModel.IContainer components = null;
        private Label label = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ClientSize = new System.Drawing.Size(384, 512);

            // disallow resize
            // this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            // this.MinimizeBox = false;

            // always on top
            this.TopMost = true;

            this.Text = "Auto Click";

            // label settings
            label = new Label();
            label.Dock = DockStyle.Top;
            label.Text = "WAITING........";

            // check box
            var left = new CheckBox();
            left.Dock = DockStyle.Top;
            left.Text = "Left Click";
            left.Click += new EventHandler((sender, e) =>
            {
                dwFlag ^= Constants.MOUSEEVENTF_LEFTDOWN | Constants.MOUSEEVENTF_LEFTUP;
            });

            var right = new CheckBox();
            right.Dock = DockStyle.Top;
            right.Text = "Right Click";
            right.Click += new EventHandler((sender, e) =>
            {
                dwFlag ^= Constants.MOUSEEVENTF_RIGHTDOWN | Constants.MOUSEEVENTF_RIGHTUP;
            });

            var middle = new CheckBox();
            middle.Dock = DockStyle.Top;
            middle.Text = "Middle Click";
            middle.Click += new EventHandler((sender, e) =>
            {
                dwFlag ^= Constants.MOUSEEVENTF_MIDDLEDOWN | Constants.MOUSEEVENTF_MIDDLEUP;
            });

            Controls.Add(middle);
            Controls.Add(right);
            Controls.Add(left);
            Controls.Add(label);

            Padding = new Padding(10);
        }
    }
}