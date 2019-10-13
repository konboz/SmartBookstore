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
    public partial class StartpageClient : Form
    {
        Bitmap lightsOut = new Bitmap("Data\bookstore-2.jpg");
        Bitmap lightsOn = new Bitmap("Data\bookstore.jpg");
        public Form form;
        public StartpageClient(Form form)
        {
            InitializeComponent();
            this.form = form;
            this.BackgroundImage = lightsOn;

        }    

        private void button3_Click(object sender, EventArgs e)
        {
            Library library = new Library(this);
            library.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (this.BackgroundImage == lightsOn)
            {
                this.BackgroundImage = lightsOut;
            }
            else
            {
                this.BackgroundImage = lightsOn;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cafe cafe = new Cafe(this);
            cafe.Show();
            Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            form.Show(this);
            Hide();
        }
    }
}
