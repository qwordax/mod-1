using System.Drawing;
using System.Windows.Forms;

namespace Generator
{
    public partial class MainForm
    {
        private void InitializeComponent()
        {
            SuspendLayout();

            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 600);
            Text = "Random Generator";

            ResumeLayout(false);
        }
    }
}
