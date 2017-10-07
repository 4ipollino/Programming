using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Services.Client;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeesClient
{
    public partial class Form1 : Form
    {
        EmployeesRef.EmployeesEntities context;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            context = new EmployeesRef.EmployeesEntities(new Uri("http://localhost:54865/MyEmployees.svc/"));
            this.empTableBindingSource.DataSource = context.EmpTable;            
        }

        private void empTableDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            context = new EmployeesRef.EmployeesEntities(new Uri("http://localhost:54865/MyEmployees.svc/"));

            try
            {
                EditForm editForm = new EditForm();
                editForm.ShowDialog(this);
                if (editForm.DialogResult == System.Windows.Forms.DialogResult.OK)
                {
                    EmployeesRef.EmpTable newEmployee = EmployeesRef.EmpTable.CreateEmpTable(editForm.ID, editForm.FirstName, editForm.LastName, editForm.BirthDate);
                    context.AddToEmpTable(newEmployee);
                    DataServiceResponse response = context.SaveChanges();
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Form1_Load(this, null);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            int row = empTableDataGridView.CurrentCellAddress.Y;
            int ID = (int)empTableDataGridView.Rows[row].Cells[0].Value;
            String FirstName = empTableDataGridView.Rows[row].Cells[1].Value.ToString();
            String LastName = empTableDataGridView.Rows[row].Cells[2].Value.ToString();
            DateTime BirthDate = (DateTime)empTableDataGridView.Rows[row].Cells[3].Value;

            context = new EmployeesRef.EmployeesEntities(new Uri("http://localhost:54865/MyEmployees.svc/"));

            try
            {
                EditForm editForm = new EditForm(ID, FirstName, LastName, BirthDate);
                editForm.numericUpDown1.Enabled = false;
                editForm.ShowDialog(this);

                if (editForm.DialogResult == System.Windows.Forms.DialogResult.OK)
                {
                    var EmployeeToUpdate = (from EmpTable in context.EmpTable
                                            where EmpTable.ID == ID 
                                            select EmpTable).Single();
                    EmployeeToUpdate.ID = editForm.ID;                    
                    EmployeeToUpdate.FirstName = editForm.FirstName;
                    EmployeeToUpdate.LastName = editForm.LastName;
                    EmployeeToUpdate.BirthDate = editForm.BirthDate;

                    //EmployeesRef.EmpTable newEmployee = EmployeesRef.EmpTable.CreateEmpTable(editForm.ID, editForm.FirstName, editForm.LastName, editForm.BirthDate);
                    context.UpdateObject(EmployeeToUpdate);

                    context.SaveChanges();
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Form1_Load(this, null);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            context = new EmployeesRef.EmployeesEntities(new Uri("http://localhost:54865/MyEmployees.svc/"));
            int ID = (int)empTableDataGridView.Rows[empTableDataGridView.CurrentCellAddress.Y].Cells[0].Value;

            try
            {
                var EmployeeToDelete = (from EmpTable in context.EmpTable
                                        where EmpTable.ID == ID
                                        select EmpTable).Single();

                //EmployeesRef.EmpTable newEmployee = EmployeesRef.EmpTable.CreateEmpTable(editForm.ID, editForm.FirstName, editForm.LastName, editForm.BirthDate);
                context.DeleteObject(EmployeeToDelete);

                context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Form1_Load(this, null);
        }
        /*
            EmployeesRef.EmployeesEntities context = new EmployeesRef.EmployeesEntities(new Uri("http://localhost:54865/MyEmployees.svc/"));

            try
            {
                if (empTableDataGridView.SelectedRows.Count != 1)
                    return;
                EmployeesRef.EmpTable newEmployee = empTableDataGridView.SelectedRows[0].DataBoundItem as EmployeesRef.EmpTable;
                EditForm editForm = new EditForm(newEmployee.ID, newEmployee.FirstName, newEmployee.LastName, newEmployee.BirthDate);
                editForm.ShowDialog(this);
                if (editForm.DialogResult == System.Windows.Forms.DialogResult.OK)
                {
                    //EmployeesRef.EmpTable newEmployee = EmployeesRef.EmpTable.CreateEmpTable(editForm.ID, editForm.FirstName, editForm.LastName, editForm.BirthDate);
                    //context.UpdateObject(
                    DataServiceResponse response = context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Form1_Load(this, null);
        }*/
    }
}
