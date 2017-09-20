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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ServiceReference1.EmployeesEntities proxy = new ServiceReference1.EmployeesEntities(new Uri("http://localhost:58698/MyEmployees.svc/"));
            empTableBindingSource.DataSource = proxy.EmpTable;
            //ServiceReference1.EmpTable newEmp = ServiceReference1.EmpTable.CreateEmpTable(24, "Kirill", "Lukichev", new DateTime(1996, 5, 4));
            //proxy.UpdateObject(newEmp);
        }
    }
}
