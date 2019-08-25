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
    public partial class Order : Form
    {
        public Form form;
        public Order(Form form, Book book)
        {
            InitializeComponent();
            this.form = form;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                groupBox2.Visible = true;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                groupBox2.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Η παραγγελία ολοκληρώθηκε!");
            var progress = new OrderProgress(this);
            Hide();
            progress.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form.Show();
            Hide();
        }
    }
}
