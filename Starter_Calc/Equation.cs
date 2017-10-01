using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Equation : Form
    {
        public Equation()
        {
            InitializeComponent();
        }

        public string result;

        private void button1_Click(object sender, EventArgs e)
        {
            double A, B, C;
            A = System.Convert.ToDouble(textBoxA.Text);
            B = System.Convert.ToDouble(textBoxB.Text);
            C = System.Convert.ToDouble(textBoxC.Text);
            double D = B * B - 4 * A * C;
            if(D < 0)
            {
                result = "No solution";
            }
            else if(D == 0)
            {
                result = "X is" + (-B / (2 * A)).ToString(); 
            }
            else
            {
                double x1 = ((-B - Math.Sqrt(D)) / (2 * A));
                double x2 = ((-B + Math.Sqrt(D)) / (2 * A));

                result = "X1 is " + x1 + ", X2 is " + x2;
            }
        }
    }
}
