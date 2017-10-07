using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthwindClient
{
    public partial class Form1 : Form
    {
        ServiceReference1.NorthwindEntities context;

        public Form1()
        {
            InitializeComponent();
            customersDataGridView.AllowUserToAddRows = true;
            customersDataGridView.AllowUserToDeleteRows = true;
            customersDataGridView.AllowUserToOrderColumns = true;
            customersDataGridView.AllowUserToResizeColumns = true;
            customersDataGridView.AllowUserToResizeRows = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ServiceReference1.NorthwindEntities proxy = new ServiceReference1.NorthwindEntities(new Uri("http://localhost:2111/NorthwindCustomers.svc/"));
            this.customersBindingSource.DataSource = proxy.Customers;
        }

        private void customersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.NorthwindEntities proxy = new ServiceReference1.NorthwindEntities(new Uri("http://localhost:2111/NorthwindCustomers.svc/"));
            string city = textBox1.Text;

            if (city != "")
            {
                this.customersBindingSource.DataSource = from c in
                                                             proxy.Customers
                                                         where c.City == city
                                                         select c;
            }

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
           
        }
    }
}
