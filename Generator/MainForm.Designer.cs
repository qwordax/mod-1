using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Generator
{
    public partial class MainForm
    {
        private GroupBox parameterBox;
        private GroupBox generatorBox;
        private GroupBox testBox;

        private Chart chart;
        private ChartArea chartArea;
        private Series chartSeries;

        private Button generateButton;
        private Button clearButton;

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;

        private NumericUpDown upDown1;
        private NumericUpDown upDown2;

        private TextBox textBox1;
        private TextBox textBox2;

        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;

        private CheckBox testCheckBox1;
        private CheckBox testCheckBox2;
        private CheckBox testCheckBox3;
        private CheckBox testCheckBox4;
        private CheckBox testCheckBox5;
        private CheckBox testCheckBox6;
        private CheckBox testCheckBox7;
        private CheckBox testCheckBox8;

        private void InitializeComponent()
        {
            parameterBox = new GroupBox();
            generatorBox = new GroupBox();
            testBox = new GroupBox();

            chart = new Chart();
            chartArea = new ChartArea();
            chartSeries = new Series();

            generateButton = new Button();
            clearButton = new Button();

            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();

            upDown1 = new NumericUpDown();
            upDown2 = new NumericUpDown();

            textBox1 = new TextBox();
            textBox2 = new TextBox();

            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();

            testCheckBox1 = new CheckBox();
            testCheckBox2 = new CheckBox();
            testCheckBox3 = new CheckBox();
            testCheckBox4 = new CheckBox();
            testCheckBox5 = new CheckBox();
            testCheckBox6 = new CheckBox();
            testCheckBox7 = new CheckBox();
            testCheckBox8 = new CheckBox();

            parameterBox.SuspendLayout();
            generatorBox.SuspendLayout();
            testBox.SuspendLayout();

            SuspendLayout();

            //
            // parameterBox.
            //
            parameterBox.Controls.AddRange(new Control[]
            {
                label1,
                label2,
                label3,
                label4,
                upDown1,
                upDown2,
                textBox1,
                textBox2
            });

            parameterBox.Location = new Point(5, 5);
            parameterBox.Margin = new Padding(0, 0, 0, 0);
            parameterBox.Name = "parameterBox";
            parameterBox.Size = new Size(300, 230);
            parameterBox.TabIndex = 0;
            parameterBox.Text = "Parameters";

            //
            // generatorBox.
            //
            generatorBox.Controls.AddRange(new RadioButton[]
            {
                radioButton1,
                radioButton2,
                radioButton3,
                radioButton4
            });

            generatorBox.Location = new Point(5, 240);
            generatorBox.Margin = new Padding(0, 0, 0, 0);
            generatorBox.Name = "generatorBox";
            generatorBox.Size = new Size(300, 225);
            generatorBox.TabIndex = 1;
            generatorBox.Text = "Generators";

            //
            // testBox.
            //
            testBox.Controls.AddRange(new CheckBox[]
            {
                testCheckBox1,
                testCheckBox2,
                testCheckBox3,
                testCheckBox4,
                testCheckBox5,
                testCheckBox6,
                testCheckBox7,
                testCheckBox8
            });

            testBox.Location = new Point(5, 470);
            testBox.Margin = new Padding(0, 0, 0, 0);
            testBox.Name = "testBox";
            testBox.Size = new Size(300, 95);
            testBox.TabIndex = 3;
            testBox.TabStop = false;
            testBox.Text = "Tests";

            //
            // chart.
            //
            chart.ChartAreas.Add(chartArea);
            chart.Location = new Point(310, 15);
            chart.Margin = new Padding(0, 0, 0, 0);
            chart.Name = "chart";
            chart.Series.Add(chartSeries);
            chart.Size = new Size(985, 695);
            chart.TabIndex = 0;
            chart.TabStop = false;

            //
            // chartArea.
            //
            chartArea.AxisX.MajorGrid.Enabled = false;
            chartArea.AxisY.Enabled = AxisEnabled.False;
            chartArea.Name = "chartArea";

            //
            // chartSeries.
            //
            chartSeries.ChartArea = "chartArea";
            chartSeries.Color = Color.Black;
            chartSeries.IsValueShownAsLabel = true;
            chartSeries.IsXValueIndexed = true;
            chartSeries.Name = "chartSeries";
            chartSeries.XValueType = ChartValueType.UInt64;
            chartSeries.YValueType = ChartValueType.UInt64;

            //
            // generateButton.
            //
            generateButton.Click += GenerateButtonClick;
            generateButton.Location = new Point(310, 715);
            generateButton.Margin = new Padding(0, 0, 0, 0);
            generateButton.Name = "generateButton";
            generateButton.Size = new Size(490, 30);
            generateButton.TabIndex = 4;
            generateButton.Text = "Generate";

            //
            // clearButton.
            //
            clearButton.Click += ClearButtonClick;
            clearButton.Location = new Point(805, 715);
            clearButton.Margin = new Padding(0, 0, 0, 0);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(490, 30);
            clearButton.TabIndex = 5;
            clearButton.Text = "Clear";

            //
            // label1.
            //
            label1.Font = new Font(label1.Font, FontStyle.Italic);
            label1.Location = new Point(5, 25);
            label1.Name = "label1";
            label1.Size = new Size(60, 30);
            label1.Text = "N";
            label1.TextAlign = ContentAlignment.MiddleLeft;

            //
            // label2.
            //
            label2.Font = new Font(label2.Font, FontStyle.Italic);
            label2.Location = new Point(5, 60);
            label2.Name = "label2";
            label2.Size = new Size(60, 30);
            label2.Text = "M";
            label2.TextAlign = ContentAlignment.MiddleLeft;

            //
            // label3.
            //
            label3.Font = new Font(label3.Font, FontStyle.Italic);
            label3.Location = new Point(5, 160);
            label3.Name = "label3";
            label3.Size = new Size(60, 30);
            label3.Text = "E";
            label3.TextAlign = ContentAlignment.MiddleLeft;

            //
            // label4.
            //
            label4.Font = new Font(label4.Font, FontStyle.Italic);
            label4.Location = new Point(5, 195);
            label4.Name = "label4";
            label4.Size = new Size(60, 30);
            label4.Text = "V";
            label4.TextAlign = ContentAlignment.MiddleLeft;

            //
            // upDown1.
            //
            upDown1.Location = new Point(70, 25);
            upDown1.Maximum = 100_000_000;
            upDown1.Minimum = 100;
            upDown1.Name = "upDown1";
            upDown1.Size = new Size(225, 30);

            upDown1.Value = 10_000;

            //
            // upDown2.
            //
            upDown2.Location = new Point(70, 60);
            upDown2.Maximum = 1_000;
            upDown2.Minimum = 10;
            upDown2.Name = "upDown2";
            upDown2.Size = new Size(225, 30);

            upDown2.Value = 100;

            //
            // textBox1.
            //
            textBox1.Location = new Point(70, 160);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(225, 30);
            textBox1.TabStop = false;

            //
            // textBox2.
            //
            textBox2.Location = new Point(70, 195);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(225, 30);
            textBox2.TabStop = false;

            //
            // radioButton1.
            //
            radioButton1.Checked = true;
            radioButton1.Font = new Font("Courier New",
                9,
                FontStyle.Regular,
                GraphicsUnit.Point);
            radioButton1.Location = new Point(5, 25);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(100, 30);
            radioButton1.TabIndex = 3;
            radioButton1.Text = "BuiltIn";

            //
            // radioButton2.
            //
            radioButton2.Font = new Font("Courier New",
                9,
                FontStyle.Regular,
                GraphicsUnit.Point);
            radioButton2.Location = new Point(5, 60);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(100, 30);
            radioButton2.TabIndex = 3;
            radioButton2.Text = "Lehmer";

            //
            // radioButton3.
            //
            radioButton3.Font = new Font("Courier New",
                9,
                FontStyle.Regular,
                GraphicsUnit.Point);
            radioButton3.Location = new Point(5, 95);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(100, 30);
            radioButton3.TabIndex = 3;
            radioButton3.Text = "MPM";

            //
            // radioButton4.
            //
            radioButton4.Font = new Font("Courier New",
                9,
                FontStyle.Regular,
                GraphicsUnit.Point);
            radioButton4.Location = new Point(5, 130);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(100, 30);
            radioButton4.TabIndex = 3;
            radioButton4.Text = "LFSR";

            //
            // testCheckBox1.
            //
            testCheckBox1.AutoCheck = false;
            testCheckBox1.Location = new Point(5, 25);
            testCheckBox1.Name = "testCheckBox1";
            testCheckBox1.Size = new Size(60, 30);
            testCheckBox1.TabIndex = 0;
            testCheckBox1.TabStop = false;
            testCheckBox1.Text = "№ 1";

            //
            // testCheckBox2.
            //
            testCheckBox2.AutoCheck = false;
            testCheckBox2.Location = new Point(70, 25);
            testCheckBox2.Name = "testCheckBox2";
            testCheckBox2.Size = new Size(60, 30);
            testCheckBox2.TabIndex = 0;
            testCheckBox2.TabStop = false;
            testCheckBox2.Text = "№ 2";

            //
            // testCheckBox3.
            //
            testCheckBox3.AutoCheck = false;
            testCheckBox3.Location = new Point(135, 25);
            testCheckBox3.Name = "testCheckBox3";
            testCheckBox3.Size = new Size(60, 30);
            testCheckBox3.TabIndex = 0;
            testCheckBox3.TabStop = false;
            testCheckBox3.Text = "№ 3";

            //
            // testCheckBox4.
            //
            testCheckBox4.AutoCheck = false;
            testCheckBox4.Location = new Point(200, 25);
            testCheckBox4.Name = "testCheckBox4";
            testCheckBox4.Size = new Size(60, 30);
            testCheckBox4.TabIndex = 0;
            testCheckBox4.TabStop = false;
            testCheckBox4.Text = "№ 4";

            //
            // testCheckBox5.
            //
            testCheckBox5.AutoCheck = false;
            testCheckBox5.Location = new Point(5, 60);
            testCheckBox5.Name = "testCheckBox5";
            testCheckBox5.Size = new Size(60, 30);
            testCheckBox5.TabIndex = 0;
            testCheckBox5.TabStop = false;
            testCheckBox5.Text = "№ 5";

            //
            // testCheckBox6.
            //
            testCheckBox6.AutoCheck = false;
            testCheckBox6.Location = new Point(70, 60);
            testCheckBox6.Name = "testCheckBox6";
            testCheckBox6.Size = new Size(60, 30);
            testCheckBox6.TabIndex = 0;
            testCheckBox6.TabStop = false;
            testCheckBox6.Text = "№ 6";

            //
            // testCheckBox7.
            //
            testCheckBox7.AutoCheck = false;
            testCheckBox7.Location = new Point(135, 60);
            testCheckBox7.Name = "testCheckBox7";
            testCheckBox7.Size = new Size(60, 30);
            testCheckBox7.TabIndex = 0;
            testCheckBox7.TabStop = false;
            testCheckBox7.Text = "№ 7";

            //
            // testCheckBox8.
            //
            testCheckBox8.AutoCheck = false;
            testCheckBox8.Location = new Point(200, 60);
            testCheckBox8.Name = "testCheckBox8";
            testCheckBox8.Size = new Size(60, 30);
            testCheckBox8.TabIndex = 0;
            testCheckBox8.TabStop = false;
            testCheckBox8.Text = "№ 8";

            //
            // MainForm.
            //
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 750);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Text = "Generator";

            Controls.Add(parameterBox);
            Controls.Add(generatorBox);
            Controls.Add(testBox);

            Controls.Add(chart);

            Controls.Add(generateButton);
            Controls.Add(clearButton);

            parameterBox.ResumeLayout(true);
            generatorBox.ResumeLayout(true);
            testBox.ResumeLayout(true);

            ResumeLayout(true);
        }
    }
}
