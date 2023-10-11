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
            Text = "Generator — Generating…";

            IRandomable generator = new BuiltIn();

            List<UInt64> values = new List<UInt64>();

            UInt64 n = (UInt64)upDown1.Value;

            if (radioButton2.Checked)
            {
                generator = new Lehmer(a: 36_786_549,
                    m: UInt64.MaxValue - 1_576,
                    x: 5_542_985_019_385);
            }

            if (radioButton3.Checked)
            {
                generator = new MPM(r0: 19_283_865,
                    r1: 9_817_279_234_659);
            }

            if (radioButton4.Checked)
            {
                generator = new LFSR(x: UInt64.MaxValue - 103_875_636_285);
            }

            for (UInt64 i = 0; i < n; i++)
            {
                values.Add(generator.Next());
            }

            Double expect = Expectation.Compute(values);
            Double variate = Variation.Compute(values);

            textBox1.Text = String.Format("{0:e}", expect);
            textBox2.Text = String.Format("{0:e}", variate);

            UInt64 m = (UInt64)upDown2.Value;

            UInt64 step = UInt64.MaxValue / m;

            UInt64[] counts = new UInt64[m];

            foreach (UInt64 value in values)
            {
                counts[value / step] += 1;
            }

            chartSeries.Points.Clear();

            for (UInt64 i = 0; i < m; i++)
            {
                chartSeries.Points.AddXY(i, counts[i]);
            }

            testCheckBox1.Checked = true;
            testCheckBox2.Checked = true;
            testCheckBox3.Checked = true;
            testCheckBox4.Checked = true;
            testCheckBox5.Checked = true;
            testCheckBox6.Checked = true;
            testCheckBox7.Checked = true;
            testCheckBox8.Checked = true;

            Text = "Generator — Done!";
        }

        private void ClearButtonClick(Object sender, EventArgs args)
        {
            Text = "Generator";

            textBox1.Text = "";
            textBox2.Text = "";

            chartSeries.Points.Clear();

            testCheckBox1.Checked = false;
            testCheckBox2.Checked = false;
            testCheckBox3.Checked = false;
            testCheckBox4.Checked = false;
            testCheckBox5.Checked = false;
            testCheckBox6.Checked = false;
            testCheckBox7.Checked = false;
            testCheckBox8.Checked = false;
        }
    }
}
