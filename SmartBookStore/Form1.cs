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
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StartpageClient startPage = new StartpageClient(this);
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

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HelpProvider help = new HelpProvider();
            help.SetShowHelp(button4, true);
            help.HelpNamespace = "Help/_ekin_nta_.htm";
        }

        private void button4_MouseClick(object sender, MouseEventArgs e)
        {
            HelpProvider help = new HelpProvider();
            help.SetShowHelp(button4, true);
            help.HelpNamespace = "Help/_ekin_nta_.htm";
        }
    }
}
