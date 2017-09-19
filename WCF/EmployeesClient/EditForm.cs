using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeesClient
{
    public partial class EditForm : Form
    {
        public int ID
        {
            get{ return (int)numericUpDown1.Value; }
            set { numericUpDown1.Value = value; }
        }

        public String FirstName
        {
            get { return textBox2.Text; }
            set { textBox2.Text = value; }
        }

        public String LastName
        {
            get { return textBox3.Text; }
            set { textBox3.Text = value; }
        }

        public DateTime BirthDate
        {
            get { return dateTimePicker1.Value; }
            set { dateTimePicker1.Value = value; }
        }

        public EditForm()
        {
            InitializeComponent();
        }

        public EditForm(int ID, String FirstName, String LastName, DateTime BirthDate)
        {
            InitializeComponent();
            this.ID = ID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.BirthDate = BirthDate;
        }
    }
}
