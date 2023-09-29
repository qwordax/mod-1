using System.Drawing;
using System.Windows.Forms;

namespace Generator
{
    public partial class MainForm
    {
        private GroupBox generatorBox;

        private void InitializeComponent()
        {
            generatorBox = new GroupBox();

            generatorBox.SuspendLayout();

            SuspendLayout();

            generatorBox.Location = new Point(5, 5);
            generatorBox.Margin = new Padding(0, 0, 0, 0);
            generatorBox.Name = "generatorBox";
            generatorBox.Size = new Size(300, 100);
            generatorBox.TabIndex = 0;
            generatorBox.TabStop = false;
            generatorBox.Text = "Generators";

            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 600);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Text = "Random Generator";

            Controls.Add(generatorBox);

            generatorBox.ResumeLayout(true);

            ResumeLayout(false);
        }
    }
}
