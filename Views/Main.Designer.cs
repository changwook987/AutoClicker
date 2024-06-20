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
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 512);

            // disallow resize
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // always on top
            this.TopMost = true;

            this.Text = "Auto Click";

            // label settings
            label = new Label();
            label.Location = new Point(0, 0);
            label.Size = new Size(384, 20);
            label.Text = "WAITING........";
            Controls.Add(label);

            // check box
            var left = new CheckBox();
            left.Text = "Left Click";
            left.Location = new Point(0, 20);
            left.Click += new EventHandler((sender, e) =>
            {
                dwFlag ^= Constants.MOUSEEVENTF_LEFTDOWN | Constants.MOUSEEVENTF_LEFTUP;
            });
            Controls.Add(left);

            var right = new CheckBox();
            right.Text = "Right Click";
            right.Location = new Point(0, 40);
            right.Click += new EventHandler((sender, e) =>
            {
                dwFlag ^= Constants.MOUSEEVENTF_RIGHTDOWN | Constants.MOUSEEVENTF_RIGHTUP;
            });
            Controls.Add(right);

            var middle = new CheckBox();
            middle.Text = "Middle Click";
            middle.Location = new Point(0, 60);
            middle.Click += new EventHandler((sender, e) =>
            {
                dwFlag ^= Constants.MOUSEEVENTF_MIDDLEDOWN | Constants.MOUSEEVENTF_MIDDLEUP;
            });
            Controls.Add(middle);
        }
    }
}