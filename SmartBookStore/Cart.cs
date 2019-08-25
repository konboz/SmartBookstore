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
    public partial class Cart : Form
    {
        Form form;
        public Cart(Form form)
        {
            InitializeComponent();
            this.form = form;
            DataTable dt = new DataTable();
            dt.Columns.Add("Τίτλος", typeof(string));
            dt.Columns.Add("Συγγραφέας", typeof(string));
            dt.Columns.Add("Τιμή", typeof(string));

            foreach (var book in GlobalVariables.cart.Books)
            {
                dt.Rows.Add(book.Title, book.Author, book.Price.ToString());
            }
            dataGridView1.DataSource = dt;
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            form.Show();
            Hide();
        }
    }
}
