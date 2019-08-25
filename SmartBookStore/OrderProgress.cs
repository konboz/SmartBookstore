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
    public partial class OrderProgress : Form
    {
        public Form form;
        int i = 0;
        List<PictureBox> pictures = new List<PictureBox>();
        public OrderProgress(Form form)
        {
            InitializeComponent();
            pictureBox1.ImageLocation = "OrderProgress/processing.jpg";
            pictureBox3.ImageLocation = "OrderProgress/packing.jpg";
            pictureBox5.ImageLocation = "OrderProgress/shipped.jpg";
            pictureBox7.ImageLocation = "OrderProgress/delivered.jpg";
            var pictures = new List<PictureBox> { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7};
            this.pictures = pictures;
            this.form = form;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictures[i].Visible = true;
            if (i > 0)
            {
                pictures[i - 1].Visible = true;
            }
            i += 2;
            if (i > 6)
            {
                timer1.Stop();
                MessageBox.Show("Η παραγγελία σας παραδόθηκε επιτυχώς!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form.Show();
            Hide();
        }
    }
}
