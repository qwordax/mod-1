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
        private Button clearButton;

        private StatusStrip statusStrip;

        private ToolStripStatusLabel statusLabel;

        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private CheckBox checkBox6;
        private CheckBox checkBox7;
        private CheckBox checkBox8;

        private void InitializeComponent()
        {
            parameterBox = new GroupBox();
            generatorBox = new GroupBox();
            testBox = new GroupBox();

            generateButton = new Button();
            clearButton = new Button();

            statusStrip = new StatusStrip();

            statusLabel = new ToolStripStatusLabel();

            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox6 = new CheckBox();
            checkBox7 = new CheckBox();
            checkBox8 = new CheckBox();

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
            parameterBox.Text = "Parameters";

            generatorBox.Location = new Point(5, 110);
            generatorBox.Margin = new Padding(0, 0, 0, 0);
            generatorBox.Name = "generatorBox";
            generatorBox.Size = new Size(300, 100);
            generatorBox.TabIndex = 1;
            generatorBox.Text = "Generators";

            testBox.Controls.AddRange(new CheckBox[] {
                checkBox1,
                checkBox2,
                checkBox3,
                checkBox4,
                checkBox5,
                checkBox6,
                checkBox7,
                checkBox8
            });

            testBox.Location = new Point(5, 215);
            testBox.Margin = new Padding(0, 0, 0, 0);
            testBox.Name = "testBox";
            testBox.Size = new Size(265, 95);
            testBox.TabIndex = 3;
            testBox.TabStop = false;
            testBox.Text = "Tests";

            generateButton.Click += GenerateButtonClick;
            generateButton.Location = new Point(400, 100);
            generateButton.Margin = new Padding(0, 0, 0, 0);
            generateButton.Name = "generateButton";
            generateButton.Size = new Size(100, 30);
            generateButton.TabIndex = 4;
            generateButton.Text = "Generate";

            clearButton.Click += ClearButtonClick;
            clearButton.Location = new Point(400, 135);
            clearButton.Margin = new Padding(0, 0, 0, 0);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(100, 30);
            clearButton.TabIndex = 5;
            clearButton.Text = "Clear";

            statusStrip.Items.Add(statusLabel);
            statusStrip.Name = "statusStrip";
            statusStrip.SizingGrip = false;
            statusStrip.TabIndex = 0;
            statusStrip.TabStop = false;

            statusLabel.Alignment = ToolStripItemAlignment.Left;
            statusLabel.Name = "toolStripStatusLabel";
            statusLabel.Text = "";

            checkBox1.AutoCheck = false;
            checkBox1.Location = new Point(5, 25);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(60, 30);
            checkBox1.TabIndex = 0;
            checkBox1.TabStop = false;
            checkBox1.Text = "№ 1";

            checkBox2.AutoCheck = false;
            checkBox2.Location = new Point(70, 25);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(60, 30);
            checkBox2.TabIndex = 0;
            checkBox2.TabStop = false;
            checkBox2.Text = "№ 2";

            checkBox3.AutoCheck = false;
            checkBox3.Location = new Point(135, 25);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(60, 30);
            checkBox3.TabIndex = 0;
            checkBox3.TabStop = false;
            checkBox3.Text = "№ 3";

            checkBox4.AutoCheck = false;
            checkBox4.Location = new Point(200, 25);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(60, 30);
            checkBox4.TabIndex = 0;
            checkBox4.TabStop = false;
            checkBox4.Text = "№ 4";

            checkBox5.AutoCheck = false;
            checkBox5.Location = new Point(5, 60);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(60, 30);
            checkBox5.TabIndex = 0;
            checkBox5.TabStop = false;
            checkBox5.Text = "№ 5";

            checkBox6.AutoCheck = false;
            checkBox6.Location = new Point(70, 60);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(60, 30);
            checkBox6.TabIndex = 0;
            checkBox6.TabStop = false;
            checkBox6.Text = "№ 6";

            checkBox7.AutoCheck = false;
            checkBox7.Location = new Point(135, 60);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(60, 30);
            checkBox7.TabIndex = 0;
            checkBox7.TabStop = false;
            checkBox7.Text = "№ 7";

            checkBox8.AutoCheck = false;
            checkBox8.Location = new Point(200, 60);
            checkBox8.Name = "checkBox8";
            checkBox8.Size = new Size(60, 30);
            checkBox8.TabIndex = 0;
            checkBox8.TabStop = false;
            checkBox8.Text = "№ 8";

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
            Controls.Add(clearButton);

            Controls.Add(statusStrip);

            parameterBox.ResumeLayout(true);
            generatorBox.ResumeLayout(true);
            testBox.ResumeLayout(true);

            statusStrip.ResumeLayout(true);

            ResumeLayout(true);
        }
    }
}
