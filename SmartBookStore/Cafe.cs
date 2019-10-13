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
    public partial class Cafe : Form
    {
        public Form form;
        public Cafe(Form form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Radio radio = new Radio(this);
            radio.Show();
            Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            form.Show(this);
            Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            CoffeOrder coffee = new CoffeOrder();
            coffee.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CoffeOrder coffee = new CoffeOrder();
            coffee.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Radio radio = new Radio(this);
            radio.Show();
            Hide();
        }
    }
}
