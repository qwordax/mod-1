using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Generator
{
    public partial class MainForm : Form
    {
        private IContainer? components = null;

        public MainForm()
        {
            this.components = new Container();

            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(800, 600);
            this.Text = "Random Generator";
        }

        protected override void Dispose(Boolean disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }
    }
}
