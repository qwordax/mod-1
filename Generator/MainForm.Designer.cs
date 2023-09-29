using System.Drawing;
using System.Windows.Forms;

namespace Generator
{
    public partial class MainForm
    {
        private GroupBox parameterBox;
        private GroupBox generatorBox;
        private GroupBox testBox;

        private Button generateButton;

        private StatusStrip statusStrip;

        private ToolStripStatusLabel statusLabel;

        private void InitializeComponent()
        {
            parameterBox = new GroupBox();
            generatorBox = new GroupBox();
            testBox = new GroupBox();

            generateButton = new Button();

            statusStrip = new StatusStrip();

            statusLabel = new ToolStripStatusLabel();

            parameterBox.SuspendLayout();
            generatorBox.SuspendLayout();
            testBox.SuspendLayout();

            statusStrip.SuspendLayout();

            SuspendLayout();

            parameterBox.Location = new Point(5, 5);
            parameterBox.Margin = new Padding(0, 0, 0, 0);
            parameterBox.Name = "parameterBox";
            parameterBox.Size = new Size(300, 100);
            parameterBox.TabIndex = 0;
            parameterBox.TabStop = false;
            parameterBox.Text = "Parameters";

            generatorBox.Location = new Point(5, 110);
            generatorBox.Margin = new Padding(0, 0, 0, 0);
            generatorBox.Name = "generatorBox";
            generatorBox.Size = new Size(300, 100);
            generatorBox.TabIndex = 1;
            generatorBox.TabStop = false;
            generatorBox.Text = "Generators";

            testBox.Location = new Point(5, 215);
            testBox.Margin = new Padding(0, 0, 0, 0);
            testBox.Name = "testBox";
            testBox.Size = new Size(300, 100);
            testBox.TabIndex = 2;
            testBox.TabStop = false;
            testBox.Text = "Tests";

            generateButton.Click += GenerateButtonClick;
            generateButton.Location = new Point(400, 100);
            generateButton.Margin = new Padding(0, 0, 0, 0);
            generateButton.Name = "generateButton";
            generateButton.Size = new Size(100, 30);
            generateButton.TabIndex = 3;
            generateButton.Text = "Generate";

            statusStrip.Items.Add(statusLabel);
            statusStrip.Name = "statusStrip";
            statusStrip.SizingGrip = false;
            statusStrip.TabIndex = 4;
            statusStrip.TabStop = false;

            statusLabel.Alignment = ToolStripItemAlignment.Left;
            statusLabel.Name = "toolStripStatusLabel";
            statusLabel.Text = "";

            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 600);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Text = "Random Generator";

            Controls.Add(parameterBox);
            Controls.Add(generatorBox);
            Controls.Add(testBox);

            Controls.Add(generateButton);

            Controls.Add(statusStrip);

            parameterBox.ResumeLayout(true);
            generatorBox.ResumeLayout(true);
            testBox.ResumeLayout(true);

            statusStrip.ResumeLayout(true);

            ResumeLayout(true);
        }
    }
}
