using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollatzConjectureStepCounter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> steps = new CollatzCalculator((long) numericUpDown1.Value).CalculateStepsRequired()
                .Select(step => string.Format("{0}) {1} {2}", step.StepNumber, step.Value, step.Message)).ToList();
            richTextBox1.Text = String.Join(Environment.NewLine,
                steps);
            label1.Text = String.Format("It took {0} steps to verify this case", steps.Count);
        }
    }
}