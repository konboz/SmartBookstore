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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StartpageClient startPage = new StartpageClient();
            startPage.Show();
            var newCart = new CartItems();
            GlobalVariables.cart = newCart;
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartPageEmployee employee = new StartPageEmployee(this);
            employee.Show();
            Hide();
        }
    }
}
