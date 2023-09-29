using System;
using System.Collections.Generic;
using System.Windows.Forms;

using Generator.Algorithms;
using Generator.Utilities;

namespace Generator
{
    /// <summary>
    /// Represents the main window of the application.
    /// </summary>
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void GenerateButtonClick(Object sender, EventArgs args)
        {
            statusLabel.Text = "Generating...";
            statusStrip.Update();

            IRandomable generator = new BuiltIn();

            List<UInt64> values = new List<UInt64>();

            UInt64 n = (UInt64)upDown1.Value;
            UInt64 m = (UInt64)upDown2.Value;

            if (radioButton1.Checked)
            {
                generator = new BuiltIn();
            }

            if (radioButton2.Checked)
            {
                generator = new Lehmer(123, 123, 123);
            }

            if (radioButton3.Checked)
            {
                generator = new MPM(123, 123);
            }

            if (radioButton4.Checked)
            {
                generator = new LFSR(123);
            }

            for (UInt64 i = 0; i < n; i++)
            {
                values.Add(generator.Next());
            }

            textBox1.Text = Expectation.Compute(values).ToString();
            textBox1.Update();

            textBox2.Text = Variation.Compute(values).ToString();
            textBox2.Update();

            statusLabel.Text = "Done!";
        }

        private void ClearButtonClick(Object sender, EventArgs args)
        {
            textBox1.Text = "";
            textBox2.Text = "";

            statusLabel.Text = "";
        }
    }
}
