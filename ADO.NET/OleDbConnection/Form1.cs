using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OleDbConnectionSpace
{
    public partial class Form1 : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        /*string testConnect = @"Provider=SQLOLEDB.1;Password=osipov;Persist Security Info=True;User ID=admin;
Initial Catalog=Northwind;Data Source=192.168.2.3,1433;Network Library=DBMSSOCN";*/
        
        private string testConnect = GetConnectionStringByName("DBConnect.NorthwindConnectionString");

        public Form1()
        {
            this.connection.StateChange += new System.Data.StateChangeEventHandler(this.connection_StateChange);
            InitializeComponent();
        }

        static string GetConnectionStringByName(string name)
        {
            string returnValue = null;
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings[name];
            if (settings != null)
                returnValue = settings.ConnectionString;
            return returnValue;
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.ConnectionString = testConnect;
                    connection.Open();
                    MessageBox.Show("Соединение установлено успешно");
                }

            }
            catch (OleDbException XcpSQL)
            {
                foreach (OleDbError se in XcpSQL.Errors)
                {
                    MessageBox.Show(se.Message,
                        "SQL Error code " + se.NativeError,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception Xcp)
            {
                MessageBox.Show(Xcp.Message,
                    "Unexpected Exception",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void closeConnectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
                MessageBox.Show("Соединение с базой данных закрыто");
            }
            else
            {
                MessageBox.Show("Соединение с базой данных уже закрыто");
            }
        }

        private void connection_StateChange(object sender, StateChangeEventArgs e)
        {
            if(e.CurrentState == ConnectionState.Open)
            {
                connectToolStripMenuItem.Enabled = false;
                closeConnectionToolStripMenuItem.Enabled = true;
            }
            else
            {
                connectToolStripMenuItem.Enabled = true;
                closeConnectionToolStripMenuItem.Enabled = false;
            }
        }

        private void connectionListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConnectionStringSettingsCollection settings = ConfigurationManager.ConnectionStrings;
            if (settings != null)
            {
                foreach (ConnectionStringSettings cs in settings)
                {
                    MessageBox.Show("name = " + cs.Name);
                    MessageBox.Show("providerName = " + cs.ProviderName);
                    MessageBox.Show("connectionString = " + cs.ConnectionString);
                }
            }
        }
    }
}
