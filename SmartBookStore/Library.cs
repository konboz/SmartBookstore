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
    public partial class Library : Form
    {
        Bitmap lightsOut = new Bitmap("Data/library-3.jpg");
        Bitmap lightsOn = new Bitmap("Data/library.jpg");
        Bitmap lightsDown = new Bitmap("Data/library-2.jpg");
        public Form form;
        string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Data/SmartBookstoreDb.mdb";
        OleDbConnection connection;
        public Library(Form form)
        {
            InitializeComponent();
            this.form = form;
            checkBox1.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string query;
            if (radioButton1.Checked)
            {
                query = "SELECT * FROM Books WHERE Author LIKE(\"" + textBox1.Text + "\")";
            }
            else
            {
                query = "SELECT * FROM Books WHERE Title LIKE(\"" + textBox1.Text + "\")";
            }

            OleDbCommand command = new OleDbCommand(query, connection);
            connection.Open();
            OleDbDataReader reader = command.ExecuteReader();
            var results = new List<Book>();
            while (reader.Read())
            {
                var book = new Book();
                book.Title = reader.GetValue(1).ToString();
                book.Author = reader.GetValue(2).ToString();
                book.Year = int.Parse(reader.GetValue(3).ToString());
                book.Paperback = reader.GetValue(4).ToString();
                book.Price = decimal.Parse(reader.GetValue(5).ToString());
                book.Image = reader.GetValue(6).ToString();
                results.Add(book);
            }
            reader.Close();
            connection.Close();

            var result = new BookResults(this, results);
            result.Show();
            Hide();
        }

        private void StartPageClient_Load(object sender, EventArgs e)
        {
            connection = new OleDbConnection(connectionString);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            form.Show();
            Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox2.Checked = false;
                this.BackgroundImage = lightsOn;
            }
            else if (!checkBox1.Checked)
            {
                this.BackgroundImage = lightsOut;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox1.Checked = false;
                this.BackgroundImage = lightsDown;
            }
            else if (!checkBox2.Checked)
            {
                this.BackgroundImage = lightsOut;
            }
        }
    }
}
