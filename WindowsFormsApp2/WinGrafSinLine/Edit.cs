using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinGrafSinLine
{
    public partial class Edit : Form
    {
        public Edit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm1 = this.Owner as Form1;
            try
            {
                frm1.a = double.Parse(DataA.Text);
                frm1.b = double.Parse(DataB.Text);
                frm1.DataA.Text = DataA.Text;
                frm1.DataB.Text = DataB.Text;
            }
            catch (Exception er)
            {
                MessageBox.Show("При выполнении ввода исходных данных возникла ошибка: \n" + er.Message,
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.Close();
            frm1.Refresh();
        }
    }
}
