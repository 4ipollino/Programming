using Calculator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Engineer : SimpleCalculator.CalcUI
    {
        public Engineer()
        {
            InitializeComponent();
        }

        private void btnSqr_Click(object sender, EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcSquare();
            CalcEngine.CalcReset();
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcReverse();
            CalcEngine.CalcReset();
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcSqrt();
            CalcEngine.CalcReset();
        }

        private void btnPower_Click(object sender, EventArgs e)
        {
            CalcEngine.CalcOperation(CalcEngine.Operator.ePower);
        }

        private void btnFact_Click(object sender, EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcFact();
            CalcEngine.CalcReset();
        }

        private void btnRoot3_Click(object sender, EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcRoot3();
            CalcEngine.CalcReset();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Equation equationDialog = new Equation();
            if (equationDialog.ShowDialog() == DialogResult.OK)
            {
                OutputDisplay.Text = equationDialog.result;
                CalcEngine.CalcReset();
            }
        }
    }
}
