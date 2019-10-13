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
    public partial class CoffeOrder : Form
    {
        public CoffeOrder()
        {
            InitializeComponent();
       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Η παραγγελία σας θα είναι έτοιμη σε λίγα λεπτά!");
            Hide();
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            button1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
