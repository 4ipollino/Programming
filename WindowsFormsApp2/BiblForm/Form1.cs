using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiblForm
{
    public partial class Form1 : Form
    {
        public string Author // автор 
        {
            get { return textBoxAuthor.Text; }
            set { textBoxAuthor.Text = value; }
        }
        public string Title // Название 
        {
            get { return textBoxName.Text; }
            set { textBoxName.Text = value; }
        }
        public string PublishHouse // Издательство 
        {
            get { return textBoxPublisher.Text; }
            set { textBoxPublisher.Text = value; }
        }
        public int Page // Количество страниц 
        {
            get { return (int) numericUpDownPages.Value; }
            set { numericUpDownPages.Value = value; }
        }
        public int Year // Год издания 
        {
            get { return (int) numericUpDownYear.Value; }
            set { numericUpDownYear.Value = value; }
        }
        public int InvNumber // Инвентарный номер 
        {
            get { return (int) numericUpDownInventory.Value; }
            set { numericUpDownInventory.Value = value; }
        }
        public int PeriodUse // Период использования
        {
            get { return (int)numericUpDownTime.Value; }
            set { numericUpDownTime.Value = value; }
        }

        public bool Existence // Наличие 
        {
            get { return checkBoxIsPresent.Checked; }
            set { checkBoxIsPresent.Checked = value; }
        }
        public bool SortInvNumber // Сортировка по инвентарному номеру 
        {
            get { return checkBoxIsSorting.Checked; }
            set { checkBoxIsSorting.Checked = value; } 
        }
        public bool ReturnTime // Возвращение в срок 
        {
            get { return checkBoxInTime.Checked; }
            set { checkBoxInTime.Checked = value; }
        }

        private List<Item> its = new List<Item>();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //Создаем книгу с указанными параметрами и добавляем в список
            Book b = new Book(Author, Title, PublishHouse, Page, Year, InvNumber, Existence);
            if (ReturnTime)
                b.ReturnSrok();
            b.PriceBook(PeriodUse);
            its.Add(b);

            //Возвращаем начальные значения
            Author = Title = PublishHouse = "";
            Page = InvNumber = PeriodUse = 0;
            Year = 1800;
            Existence = ReturnTime = false;
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            if (SortInvNumber)
                its.Sort();
            StringBuilder sb = new StringBuilder();
            foreach(Item item in its)
            {
                sb.Append("\n" + item.ToString());                
            }
            richTextBox1.Text = sb.ToString();
        }
    }
}
