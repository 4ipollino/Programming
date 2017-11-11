﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using CodeFirst;

namespace CustomerManager
{
    public partial class Form1 : Form
    {
        SampleContext context;
        byte[] Ph;

        public Form1()
        {
            context = new SampleContext();
            //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<SampleContext>()); 
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<SampleContext>()); 
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try             
            {                
                var selOrders = orderlistBox.SelectedItems.OfType<Order>().ToList();
                foreach(Order o in selOrders)
                {
                    context.Orders.Add(o);
                }
                
                Customer customer = new Customer 
                { 
                    FirstName = this.textBoxname.Text, 
                    LastName = this.textBoxlastname.Text, 
                    Email = this.textBoxmail.Text, 
                    Age = Int32.Parse(this.textBoxage.Text), 
                    Orders = orderlistBox.SelectedItems.OfType<Order>().ToList(), 
                    Photo = Ph 
                }; 
                
                context.Customers.Add(customer); 
                context.SaveChanges();    
                textBoxname.Text = String.Empty;
                textBoxlastname.Text = String.Empty;
                textBoxmail.Text = String.Empty; 
                textBoxage.Text = String.Empty;
            } 
            catch(Exception ex)    
            {     
                MessageBox.Show("Ошибка: " + ex.Message);       
            }     
        }

        private void Output()
        {
            if (this.CustomerradioButton.Checked == true)
                GridView.DataSource = context.Customers.ToList();
            else if (this.OrderradioButton.Checked == true) 
                GridView.DataSource = context.Orders.ToList();
            else if (this.ViporderradioButton.Checked == true) 
                GridView.DataSource = context.VipOrders.ToList(); 
        } 

        private void buttonFile_Click(object sender, EventArgs e)
        {
            if (diag.ShowDialog() == DialogResult.OK) 
            { 
                Image bm = new Bitmap(diag.OpenFile()); 
                ImageConverter converter = new ImageConverter(); 
                Ph = (byte[])converter.ConvertTo(bm, typeof(byte[])); 
            } 
        }

        private void buttonOut_Click(object sender, EventArgs e)
        {
            Output();
            var query = from b in context.Customers orderby b.FirstName select b;
            customerList.DataSource = query.ToList();
        }

        private void CustomerradioButton_CheckedChanged(object sender, EventArgs e)
        {
            //Output();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            context.Orders.Add(
                new Order
                { 
                    ProductName = "Аудио", 
                    Quantity = 12, 
                    PurchaseDate = DateTime.Parse("12.01.2016") 
                }); 
            context.Orders.Add(
                new Order 
                { ProductName = "Видео", 
                    Quantity = 22, 
                    PurchaseDate = DateTime.Parse("10.01.2016") 
                }); context.SaveChanges(); 
            orderlistBox.DataSource = context.Orders.ToList();
            context.VipOrders.Add(
                new VipOrder 
                { 
                    ProductName = "Авто", 
                    Quantity = 101, 
                    PurchaseDate = DateTime.Parse("10.01.2016"), 
                    status = "Высокий" 
                }); 
        }

        private void GridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridView.CurrentRow == null) return;
            var customer = GridView.CurrentRow.DataBoundItem as Customer;
            if (customer == null) return; 
            labelid.Text = Convert.ToString(customer.CustomerId);      
            textBoxCustomer.Text = customer.ToString();       
            textBoxname.Text = customer.FirstName;     
            textBoxlastname.Text = customer.LastName;
            textBoxmail.Text = customer.Email; 
            textBoxage.Text = Convert.ToString(customer.Age); 
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
                if (labelid.Text == String.Empty) return;
                var id = Convert.ToInt32(labelid.Text);
                var customer = context.Customers.Find(id);
                if (customer == null) return;
                customer.FirstName = this.textBoxname.Text;
                customer.LastName = this.textBoxlastname.Text;
                customer.Email = this.textBoxmail.Text;
                customer.Age = Int32.Parse(this.textBoxage.Text);
                context.Entry(customer).State = EntityState.Modified;
                context.SaveChanges();
                Output();
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (labelid.Text == String.Empty) return;
                var id = Convert.ToInt32(labelid.Text);
                var customer = context.Customers.Find(id);
                context.Entry(customer).State = EntityState.Deleted;
                context.SaveChanges();
                Output();
            }
            catch
            {
            }
        } 
    }
}