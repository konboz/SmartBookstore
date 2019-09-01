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
    public partial class StartPageClient : Form
    {
        string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=BookstoreDb.mdb";
        OleDbConnection connection;
        public StartPageClient()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseClick(object sender, EventArgs e)
        {
            textBox1.Clear();
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
    }
}
