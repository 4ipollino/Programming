using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task5_Part2
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void greenpeaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RhombusForm rhombusForm = new RhombusForm();
            rhombusForm.MdiParent = this;
            this.greenpeaceToolStripMenuItem.Enabled = false;
            rhombusForm.Show();
            rhombusForm.FormClosed += RhombusForm_FormClosed;
        }

        private void RhombusForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.greenpeaceToolStripMenuItem.Enabled = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
