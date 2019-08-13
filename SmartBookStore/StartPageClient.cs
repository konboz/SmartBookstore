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
        string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=BookStoreDb.mdb";
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
            connection.Open();
            if (radioButton1.Checked)
            {
                string query = "SELECT Title FROM Books WHERE Title LIKE(\"" + textBox1 + "\")";
                OleDbCommand command = new OleDbCommand(query, connection);
                OleDbDataReader reader = command.ExecuteReader();
            }
            else if (radioButton2.Checked)
            {
                string query = "SELECT Title FROM Books WHERE Author LIKE(\"" + textBox1 + "\")";
                OleDbCommand command = new OleDbCommand(query, connection);
                OleDbDataReader reader = command.ExecuteReader();
            }
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
