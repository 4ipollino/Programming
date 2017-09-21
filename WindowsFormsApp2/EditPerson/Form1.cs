using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace EditPerson
{
    public partial class Form1 : Form
    {
        List<Person> pers = new List<Person>();

        public Form1()
        {
            InitializeComponent();

            //BinaryFormatter binaryFormatter = new BinaryFormatter();
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Person>));

            try
            {
                /*using (FileStream fStream = new FileStream("AllMyPerson.dat", FileMode.OpenOrCreate, FileAccess.Read, FileShare.None))
                {
                    pers.AddRange((List<Person>)binaryFormatter.Deserialize(fStream));
                    personsListView.VirtualListSize = pers.Count;
                    personsListView.Invalidate();
                }*/

                using (FileStream fStream = new FileStream("PersonCollection.xml", FileMode.OpenOrCreate, FileAccess.Read, FileShare.None))
                {
                    pers.AddRange((List<Person>)xmlSerializer.Deserialize(fStream));
                    personsListView.VirtualListSize = pers.Count;
                    personsListView.Invalidate();
                }
            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Person p = new Person();
            EditPersonForm editForm = new EditPersonForm(p);
            if (editForm.ShowDialog() != DialogResult.OK)
                return;
            pers.Add(p);
            personsListView.VirtualListSize = pers.Count;
            personsListView.Invalidate();
            /*ListViewItem newItem = personsListView.Items.Add(editForm.FirstName);
            newItem.SubItems.Add(editForm.LastName);
            newItem.SubItems.Add(editForm.Age.ToString());*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (personsListView.SelectedIndices.Count == 0)
                return;
            Person p = pers[personsListView.SelectedIndices[0]];
            //ListViewItem item = personsListView.SelectedItems[0];
            EditPersonForm editForm = new EditPersonForm(p);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                personsListView.Invalidate();
            }
            /*editForm.FirstName = item.Text;
            editForm.LastName = item.SubItems[1].Text;
            editForm.Age = Convert.ToInt32(item.SubItems[2].Text);
            if (editForm.ShowDialog() != DialogResult.OK)
                return;
            item.Text = editForm.FirstName;
            item.SubItems[1].Text = editForm.LastName;
            item.SubItems[2].Text = editForm.Age.ToString();*/
        }

        private void personsListView_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
        {
            if (e.ItemIndex >= 0 && e.ItemIndex < pers.Count)
            {
                e.Item = new ListViewItem(pers[e.ItemIndex].FirstName);
                e.Item.SubItems.Add(pers[e.ItemIndex].LastName);
                e.Item.SubItems.Add(pers[e.ItemIndex].Age.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder(); foreach (Person item in pers)
            {
                sb.Append("Сотрудник: \n" + item.ToString());
            }
            richTextBox1.Text = sb.ToString();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*BinaryFormatter binaryFormatter = new BinaryFormatter();
            using (FileStream fStream = new FileStream("AllMyPerson.dat", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                binaryFormatter.Serialize(fStream, pers);
            }*/

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Person>));
            using (FileStream fStream = new FileStream("PersonCollection.xml", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                xmlSerializer.Serialize(fStream, pers);
            }
        }
    }
}
