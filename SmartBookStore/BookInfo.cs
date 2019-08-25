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
        public Form form;
        Book book = new Book();
        public BookInfo(Form form, Book book)
        {
            InitializeComponent();
            this.book = book;
            this.form = form;
            textBox1.Text = book.Title;
            textBox2.Text = book.Author;
            textBox3.Text = book.Year.ToString();
            textBox4.Text = book.Paperback;
            textBox5.Text = book.Price.ToString() + " $";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Utilities.BookAdd(book);
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var cart = new Cart(this);
            cart.Show();
            Hide();
        }
    }
}
