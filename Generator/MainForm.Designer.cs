using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Generator
{
    public partial class MainForm
    {
        private GroupBox parameterBox;
        private GroupBox expectedBox;
        private GroupBox computedBox;
        private GroupBox generatorBox;
        private GroupBox testBox;

        private Chart chart;
        private ChartArea chartArea;
        private Series chartSeries;

        private CheckBox checkBox;

        private Button generateButton;
        private Button clearButton;

        private Label parameterLabel1;
        private Label parameterLabel2;

        private NumericUpDown parameterUpDown1;
        private NumericUpDown parameterUpDown2;

        private Label expectedLabel1;
        private Label expectedLabel2;

        private TextBox expectedTextBox1;
        private TextBox expectedTextBox2;

        private Label computedLabel1;
        private Label computedLabel2;

        private TextBox computedTextBox1;
        private TextBox computedTextBox2;

        private RadioButton generatorButton1;
        private RadioButton generatorButton2;
        private RadioButton generatorButton3;
        private RadioButton generatorButton4;

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
            expectedBox = new GroupBox();
            computedBox = new GroupBox();
            generatorBox = new GroupBox();
            testBox = new GroupBox();

            chart = new Chart();
            chartArea = new ChartArea();
            chartSeries = new Series();

            checkBox = new CheckBox();

            generateButton = new Button();
            clearButton = new Button();

            parameterLabel1 = new Label();
            parameterLabel2 = new Label();

            parameterUpDown1 = new NumericUpDown();
            parameterUpDown2 = new NumericUpDown();

            expectedLabel1 = new Label();
            expectedLabel2 = new Label();

            expectedTextBox1 = new TextBox();
            expectedTextBox2 = new TextBox();

            computedLabel1 = new Label();
            computedLabel2 = new Label();

            computedTextBox1 = new TextBox();
            computedTextBox2 = new TextBox();

            generatorButton1 = new RadioButton();
            generatorButton2 = new RadioButton();
            generatorButton3 = new RadioButton();
            generatorButton4 = new RadioButton();

            testCheckBox1 = new CheckBox();
            testCheckBox2 = new CheckBox();
            testCheckBox3 = new CheckBox();
            testCheckBox4 = new CheckBox();
            testCheckBox5 = new CheckBox();
            testCheckBox6 = new CheckBox();
            testCheckBox7 = new CheckBox();
            testCheckBox8 = new CheckBox();

            parameterBox.SuspendLayout();
            expectedBox.SuspendLayout();
            computedBox.SuspendLayout();
            generatorBox.SuspendLayout();
            testBox.SuspendLayout();

            SuspendLayout();

            //
            // parameterBox.
            //
            parameterBox.Controls.AddRange(new Control[]
            {
                parameterLabel1,
                parameterLabel2,
                parameterUpDown1,
                parameterUpDown2
            });

            parameterBox.Location = new Point(5, 5);
            parameterBox.Name = "parameterBox";
            parameterBox.Size = new Size(300, 95);
            parameterBox.Text = "Parameters";

            //
            // expectedBox.
            //
            expectedBox.Controls.AddRange(new Control[]
            {
                expectedLabel1,
                expectedLabel2,
                expectedTextBox1,
                expectedTextBox2
            });

            expectedBox.Location = new Point(5, 105);
            expectedBox.Name = "expectedBox";
            expectedBox.Size = new Size(300, 95);
            expectedBox.Text = "Expected";

            //
            // computedBox.
            //
            computedBox.Controls.AddRange(new Control[]
            {
                computedLabel1,
                computedLabel2,
                computedTextBox1,
                computedTextBox2
            });

            computedBox.Location = new Point(5, 205);
            computedBox.Name = "computedBox";
            computedBox.Size = new Size(300, 95);
            computedBox.Text = "Computed";

            //
            // generatorBox.
            //
            generatorBox.Controls.AddRange(new RadioButton[]
            {
                generatorButton1,
                generatorButton2,
                generatorButton3,
                generatorButton4
            });

            generatorBox.Location = new Point(5, 305);
            generatorBox.Name = "generatorBox";
            generatorBox.Size = new Size(300, 305);
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

            testBox.Location = new Point(5, 615);
            testBox.Name = "testBox";
            testBox.Size = new Size(300, 95);
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
            chart.TabStop = false;

            //
            // chartArea.
            //
            chartArea.AxisX.MajorGrid.Enabled = false;
            chartArea.AxisY.MajorGrid.Enabled = false;
            chartArea.Name = "chartArea";

            //
            // chartSeries.
            //
            chartSeries.ChartArea = "chartArea";
            chartSeries.Color = Color.Black;
            chartSeries.IsXValueIndexed = true;
            chartSeries.Name = "chartSeries";
            chartSeries.XValueType = ChartValueType.UInt64;
            chartSeries.YValueType = ChartValueType.UInt64;

            //
            // checkBox.
            //
            checkBox.CheckedChanged += CheckBoxCheckedChange;
            checkBox.Location = new Point(10, 715);
            checkBox.Name = "checkBox";
            checkBox.Size = new Size(295, 30);
            checkBox.Text = "Show Labels";

            //
            // generateButton.
            //
            generateButton.Click += GenerateButtonClick;
            generateButton.Location = new Point(310, 715);
            generateButton.Margin = new Padding(0, 0, 0, 0);
            generateButton.Name = "generateButton";
            generateButton.Size = new Size(490, 30);
            generateButton.Text = "Generate";

            //
            // clearButton.
            //
            clearButton.Click += ClearButtonClick;
            clearButton.Location = new Point(805, 715);
            clearButton.Margin = new Padding(0, 0, 0, 0);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(490, 30);
            clearButton.Text = "Clear";

            //
            // parameterLabel1.
            //
            parameterLabel1.Font = new Font(parameterLabel1.Font, FontStyle.Italic);
            parameterLabel1.Location = new Point(5, 25);
            parameterLabel1.Name = "parameterLabel1";
            parameterLabel1.Size = new Size(60, 30);
            parameterLabel1.Text = "N";
            parameterLabel1.TextAlign = ContentAlignment.MiddleLeft;

            //
            // parameterLabel2.
            //
            parameterLabel2.Font = new Font(parameterLabel2.Font, FontStyle.Italic);
            parameterLabel2.Location = new Point(5, 60);
            parameterLabel2.Name = "parameterLabel2";
            parameterLabel2.Size = new Size(60, 30);
            parameterLabel2.Text = "K";
            parameterLabel2.TextAlign = ContentAlignment.MiddleLeft;

            //
            // parameterUpDown1.
            //
            parameterUpDown1.Location = new Point(100, 25);
            parameterUpDown1.Maximum = 100_000_000;
            parameterUpDown1.Minimum = 100;
            parameterUpDown1.Name = "parameterUpDown1";
            parameterUpDown1.Size = new Size(195, 30);
            parameterUpDown1.TextAlign = HorizontalAlignment.Right;
            parameterUpDown1.UpDownAlign = LeftRightAlignment.Left;

            parameterUpDown1.Value = 10_000;

            //
            // parameterUpDown2.
            //
            parameterUpDown2.Location = new Point(100, 60);
            parameterUpDown2.Maximum = 1_000;
            parameterUpDown2.Minimum = 10;
            parameterUpDown2.Name = "parameterUpDown2";
            parameterUpDown2.Size = new Size(195, 30);
            parameterUpDown2.TextAlign = HorizontalAlignment.Right;
            parameterUpDown2.UpDownAlign = LeftRightAlignment.Left;

            parameterUpDown2.Value = 256;

            //
            // expectedLabel1.
            //
            expectedLabel1.Font = new Font(expectedLabel1.Font, FontStyle.Italic);
            expectedLabel1.Location = new Point(5, 25);
            expectedLabel1.Name = "expectedLabel1";
            expectedLabel1.Size = new Size(60, 30);
            expectedLabel1.Text = "M";
            expectedLabel1.TextAlign = ContentAlignment.MiddleLeft;

            //
            // expectedLabel2.
            //
            expectedLabel2.Font = new Font(expectedLabel2.Font, FontStyle.Italic);
            expectedLabel2.Location = new Point(5, 60);
            expectedLabel2.Name = "expectedLabel2";
            expectedLabel2.Size = new Size(60, 30);
            expectedLabel2.Text = "V";
            expectedLabel2.TextAlign = ContentAlignment.MiddleLeft;

            //
            // expectedTextBox1.
            //
            expectedTextBox1.Location = new Point(100, 25);
            expectedTextBox1.Name = "expectedTextBox1";
            expectedTextBox1.ReadOnly = true;
            expectedTextBox1.Size = new Size(195, 30);
            expectedTextBox1.TabStop = false;
            expectedTextBox1.TextAlign = HorizontalAlignment.Right;

            //
            // expectedTextBox2.
            //
            expectedTextBox2.Location = new Point(100, 60);
            expectedTextBox2.Name = "expectedTextBox2";
            expectedTextBox2.ReadOnly = true;
            expectedTextBox2.Size = new Size(195, 30);
            expectedTextBox2.TabStop = false;
            expectedTextBox2.TextAlign = HorizontalAlignment.Right;

            //
            // computedLabel1.
            //
            computedLabel1.Font = new Font(computedLabel1.Font, FontStyle.Italic);
            computedLabel1.Location = new Point(5, 25);
            computedLabel1.Name = "computedLabel1";
            computedLabel1.Size = new Size(60, 30);
            computedLabel1.Text = "M";
            computedLabel1.TextAlign = ContentAlignment.MiddleLeft;

            //
            // computedLabel2.
            //
            computedLabel2.Font = new Font(computedLabel2.Font, FontStyle.Italic);
            computedLabel2.Location = new Point(5, 60);
            computedLabel2.Name = "computedLabel2";
            computedLabel2.Size = new Size(60, 30);
            computedLabel2.Text = "V";
            computedLabel2.TextAlign = ContentAlignment.MiddleLeft;

            //
            // computedTextBox1.
            //
            computedTextBox1.Location = new Point(100, 25);
            computedTextBox1.Name = "computedTextBox1";
            computedTextBox1.ReadOnly = true;
            computedTextBox1.Size = new Size(195, 30);
            computedTextBox1.TabStop = false;
            computedTextBox1.TextAlign = HorizontalAlignment.Right;

            //
            // computedTextBox2.
            //
            computedTextBox2.Location = new Point(100, 60);
            computedTextBox2.Name = "computedTextBox2";
            computedTextBox2.ReadOnly = true;
            computedTextBox2.Size = new Size(195, 30);
            computedTextBox2.TabStop = false;
            computedTextBox2.TextAlign = HorizontalAlignment.Right;

            //
            // generatorButton1.
            //
            generatorButton1.Checked = true;
            generatorButton1.Font = new Font("Courier New",
                9,
                FontStyle.Regular,
                GraphicsUnit.Point);
            generatorButton1.Location = new Point(5, 25);
            generatorButton1.Name = "generatorButton1";
            generatorButton1.Size = new Size(100, 30);
            generatorButton1.Text = "BuiltIn";

            //
            // generatorButton2.
            //
            generatorButton2.Font = new Font("Courier New",
                9,
                FontStyle.Regular,
                GraphicsUnit.Point);
            generatorButton2.Location = new Point(5, 60);
            generatorButton2.Name = "generatorButton2";
            generatorButton2.Size = new Size(100, 30);
            generatorButton2.Text = "Lehmer";

            //
            // generatorButton3.
            //
            generatorButton3.Font = new Font("Courier New",
                9,
                FontStyle.Regular,
                GraphicsUnit.Point);
            generatorButton3.Location = new Point(5, 95);
            generatorButton3.Name = "generatorButton3";
            generatorButton3.Size = new Size(100, 30);
            generatorButton3.Text = "MPM";

            //
            // generatorButton4.
            //
            generatorButton4.Font = new Font("Courier New",
                9,
                FontStyle.Regular,
                GraphicsUnit.Point);
            generatorButton4.Location = new Point(5, 130);
            generatorButton4.Name = "generatorButton4";
            generatorButton4.Size = new Size(100, 30);
            generatorButton4.Text = "LFSR";

            //
            // testCheckBox1.
            //
            testCheckBox1.AutoCheck = false;
            testCheckBox1.Location = new Point(5, 25);
            testCheckBox1.Name = "testCheckBox1";
            testCheckBox1.Size = new Size(60, 30);
            testCheckBox1.TabStop = false;
            testCheckBox1.Text = "№ 1";

            //
            // testCheckBox2.
            //
            testCheckBox2.AutoCheck = false;
            testCheckBox2.Location = new Point(70, 25);
            testCheckBox2.Name = "testCheckBox2";
            testCheckBox2.Size = new Size(60, 30);
            testCheckBox2.TabStop = false;
            testCheckBox2.Text = "№ 2";

            //
            // testCheckBox3.
            //
            testCheckBox3.AutoCheck = false;
            testCheckBox3.Location = new Point(135, 25);
            testCheckBox3.Name = "testCheckBox3";
            testCheckBox3.Size = new Size(60, 30);
            testCheckBox3.TabStop = false;
            testCheckBox3.Text = "№ 3";

            //
            // testCheckBox4.
            //
            testCheckBox4.AutoCheck = false;
            testCheckBox4.Location = new Point(200, 25);
            testCheckBox4.Name = "testCheckBox4";
            testCheckBox4.Size = new Size(60, 30);
            testCheckBox4.TabStop = false;
            testCheckBox4.Text = "№ 4";

            //
            // testCheckBox5.
            //
            testCheckBox5.AutoCheck = false;
            testCheckBox5.Location = new Point(5, 60);
            testCheckBox5.Name = "testCheckBox5";
            testCheckBox5.Size = new Size(60, 30);
            testCheckBox5.TabStop = false;
            testCheckBox5.Text = "№ 5";

            //
            // testCheckBox6.
            //
            testCheckBox6.AutoCheck = false;
            testCheckBox6.Location = new Point(70, 60);
            testCheckBox6.Name = "testCheckBox6";
            testCheckBox6.Size = new Size(60, 30);
            testCheckBox6.TabStop = false;
            testCheckBox6.Text = "№ 6";

            //
            // testCheckBox7.
            //
            testCheckBox7.AutoCheck = false;
            testCheckBox7.Location = new Point(135, 60);
            testCheckBox7.Name = "testCheckBox7";
            testCheckBox7.Size = new Size(60, 30);
            testCheckBox7.TabStop = false;
            testCheckBox7.Text = "№ 7";

            //
            // testCheckBox8.
            //
            testCheckBox8.AutoCheck = false;
            testCheckBox8.Location = new Point(200, 60);
            testCheckBox8.Name = "testCheckBox8";
            testCheckBox8.Size = new Size(60, 30);
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

            Controls.AddRange(new GroupBox[]
            {
                parameterBox,
                expectedBox,
                computedBox,
                generatorBox,
                testBox
            });

            Controls.Add(chart);

            Controls.Add(checkBox);

            Controls.AddRange(new Button[]
            {
                generateButton,
                clearButton
            });

            parameterBox.ResumeLayout(true);
            expectedBox.ResumeLayout(true);
            computedBox.ResumeLayout(true);
            generatorBox.ResumeLayout(true);
            testBox.ResumeLayout(true);

            ResumeLayout(true);
        }
    }
}
