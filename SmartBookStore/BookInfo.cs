using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartBookStore
{
    public partial class BookInfo : Form
    {
        Book book = new Book();
        public BookInfo(Book book)
        {
            InitializeComponent();
            this.book = book;
            textBox1.Text = book.Title;
            textBox2.Text = book.Author;
            textBox3.Text = book.Year.ToString();
            textBox4.Text = book.Paperback;
            textBox5.Text = book.Price.ToString() + " $";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
