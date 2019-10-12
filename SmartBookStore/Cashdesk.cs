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
    public partial class Cashdesk : Form
    {
        public Form form;
        public Cashdesk(Form form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Checkout check = new Checkout(this);
            check.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form.Show();
            Hide();
        }
    }
}
