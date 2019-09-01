using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace SmartBookStore
{
    public partial class BookResults : Form
    {
        public Form form;
        List<Book> results = new List<Book>();
        public BookResults(Form form, List<Book> results)
        {
            InitializeComponent();
            this.results = results;
            this.form = form;
            var titles = new List<TextBox> { textBox1, textBox3, textBox5, textBox7, textBox9};
            var authors = new List<TextBox> { textBox2, textBox4, textBox6, textBox8, textBox10 };
            int i = 0;

            foreach (Book item in results)
            {
                titles[i].Text = item.Title;
                authors[i].Text = item.Author;
                i++;  
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var book = new BookInfo(this, results[0]);
            book.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var book = new BookInfo(this, results[1]);
            book.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var book = new BookInfo(this, results[2]);
            book.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var book = new BookInfo(this, results[3]);
            book.Show();
            Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var book = new BookInfo(this, results[4]);
            book.Show();
            Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            form.Show();
            Hide();
        }
    }
}
