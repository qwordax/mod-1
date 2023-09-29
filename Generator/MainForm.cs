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

            Double expect = Expectation.Compute(values);
            Double variate = Variation.Compute(values);

            textBox1.Text = String.Format("{0:e}", expect);
            textBox2.Text = String.Format("{0:e}", variate);

            parameterBox.Update();

            checkBox1.Checked = true;
            checkBox2.Checked = true;
            checkBox3.Checked = true;
            checkBox4.Checked = true;
            checkBox5.Checked = true;
            checkBox6.Checked = true;
            checkBox7.Checked = true;
            checkBox8.Checked = true;

            statusLabel.Text = "Done!";
        }

        private void ClearButtonClick(Object sender, EventArgs args)
        {
            textBox1.Text = "";
            textBox2.Text = "";

            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;

            statusLabel.Text = "";
        }
    }
}
