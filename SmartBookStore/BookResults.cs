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
        public BookResults(OleDbDataReader reader)
        {
            InitializeComponent();
            while (reader.Read())
            {
                textBox1.Text = reader[0].ToString();
            }
        }
    }
}
