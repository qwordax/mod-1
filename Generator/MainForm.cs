using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

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

            if (radioButton2.Checked)
            {
                generator = new Lehmer(36_786_549,
                    UInt64.MaxValue,
                    5_542_985_019_385);
            }

            if (radioButton3.Checked)
            {
                generator = new MPM(19_283_865, 9_817_279_234_659);
            }

            if (radioButton4.Checked)
            {
                generator = new LFSR(UInt64.MaxValue - 103_875_636_285);
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

            chartSeries.Points.Clear();

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
