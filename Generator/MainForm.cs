using System;
using System.Collections.Generic;
using System.Windows.Forms;

using TrulyRandom;

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

        private void CheckBoxCheckedChange(Object sender, EventArgs args)
        {
            chartSeries.IsValueShownAsLabel = checkBox.Checked;
        }

        private void GenerateButtonClick(Object sender, EventArgs args)
        {
            Text = "Generator — Generating…";

            IRandomable generator = new BuiltIn();

            List<UInt64> values = new List<UInt64>();

            UInt64 n = (UInt64)parameterUpDown1.Value;

            if (generatorButton2.Checked)
            {
                generator = new Lehmer(a: 36_786_549,
                    m: UInt64.MaxValue - 1_576,
                    x: 5_542_985_019_385);
            }

            if (generatorButton3.Checked)
            {
                generator = new MPM(r0: 19_283_865,
                    r1: 9_817_279_234_659);
            }

            if (generatorButton4.Checked)
            {
                generator = new LFSR(x: UInt64.MaxValue - 103_875_636_285);
            }

            for (UInt64 i = 0; i < n; i++)
            {
                values.Add(generator.Next());
            }

            Double expectM = (Double)UInt64.MaxValue / 2.0;
            Double expectV = (Double)UInt64.MaxValue * UInt64.MaxValue / 12.0;

            Double computeM = Mean.Compute(values);
            Double computeV = Variation.Compute(values);

            expectedTextBox1.Text = String.Format("{0:E}", expectM);
            expectedTextBox2.Text = String.Format("{0:E}", expectV);

            computedTextBox1.Text = String.Format("{0:E}", computeM);
            computedTextBox2.Text = String.Format("{0:E}", computeV);

            UInt64 k = (UInt64)parameterUpDown2.Value;

            UInt64 step = UInt64.MaxValue / k;

            UInt64[] counts = new UInt64[k];

            foreach (UInt64 value in values)
            {
                counts[value / step] += 1;
            }

            chartSeries.Points.Clear();

            for (UInt64 i = 0; i < k; i++)
            {
                chartSeries.Points.AddXY(i, counts[i]);
            }

            List<Byte> bytes = new List<Byte>();

            foreach (UInt64 value in values)
            {
                bytes.AddRange(BitConverter.GetBytes(value));
            }

            Text = "Generator — Testing ¹ 1…";

            testCheckBox1.Checked = n >= (0x1 << 25) ||
                NistTests.Frequency(bytes.ToArray()).PValues[0] >= 0.01;

            Text = "Generator — Testing ¹ 2…";

            testCheckBox2.Checked = n >= (0x1 << 25) ||
                NistTests.BlockFrequency(bytes.ToArray(), 128).PValues[0] >= 0.01;

            Text = "Generator — Testing ¹ 3…";

            testCheckBox3.Checked = n >= (0x1 << 25) ||
                NistTests.Runs(bytes.ToArray()).PValues[0] >= 0.01;

            Text = "Generator — Testing ¹ 4…";

            testCheckBox4.Checked = n >= (0x1 << 25) ||
                NistTests.LongestRunOfOnes(bytes.ToArray()).PValues[0] >= 0.01;

            Text = "Generator — Testing ¹ 5…";

            testCheckBox5.Checked = n >= (0x1 << 25) ||
                NistTests.BinaryMatrixRank(bytes.ToArray(), -1).PValues[0] >= 0.01;

            Text = "Generator — Testing ¹ 6…";

            testCheckBox6.Checked = n >= (0x1 << 25) ||
                NistTests.DiscreteFourierTransform(bytes.ToArray()).PValues[0] >= 0.01;

            Text = "Generator — Testing ¹ 7…";

            testCheckBox7.Checked = n >= (0x1 << 25) ||
                NistTests.NonOverlappingTemplateMatchings(bytes.ToArray(), -1, -1).PValues[0] >= 0.01;

            Text = "Generator — Testing ¹ 8…";

            testCheckBox8.Checked = n >= (0x1 << 25) ||
                NistTests.OverlappingTemplateMatchings(bytes.ToArray(), -1, -1, -1).PValues[0] >= 0.01;

            Text = "Generator — Done!";
        }

        private void ClearButtonClick(Object sender, EventArgs args)
        {
            Text = "Generator";

            chartSeries.Points.Clear();

            expectedTextBox1.Text = "";
            expectedTextBox2.Text = "";

            computedTextBox1.Text = "";
            computedTextBox2.Text = "";

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
