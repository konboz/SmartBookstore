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
    public partial class StartPageEmployee : Form
    {
        
        Bitmap lightsOff = new Bitmap("Data/emplbookstore2.jpg");
        Bitmap lightsOn = new Bitmap("Data/emplbookstore.jpg");
        Bitmap lightsCafe = new Bitmap("Data/emplbookstore3.jpeg");
        Bitmap lightsBooks = new Bitmap("Data/emplbookstore4.jpeg");
        Bitmap lightsPrint = new Bitmap("Data/emplbookstore5.jpeg"); 
        public Form form;
        public StartPageEmployee(Form form)
        {
            InitializeComponent();
            this.form = form;
            checkBox4.Checked = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cashdesk cash = new Cashdesk(this);
            cash.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form.Show();
            Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {  
            if (checkBox1.Checked)
            {
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                this.BackgroundImage = lightsBooks;
            }
            else if (!checkBox1.Checked)
            {
                this.BackgroundImage = lightsOff;
            }  
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {    
            if (checkBox2.Checked)
            {
                checkBox1.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                this.BackgroundImage = lightsPrint;
            }
            else if (!checkBox2.Checked)
            {
                this.BackgroundImage = lightsOff;
            }    
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {    
            if (checkBox3.Checked)
            {
                checkBox2.Checked = false;
                checkBox1.Checked = false;
                checkBox4.Checked = false;
                this.BackgroundImage = lightsCafe;
            }
            else if (!checkBox3.Checked)
            {
                this.BackgroundImage = lightsOff;
            }    
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {   
            if (checkBox4.Checked)
            {
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox1.Checked = false;
                this.BackgroundImage = lightsOn;
            }
            else if (!checkBox4.Checked)
            {
                this.BackgroundImage = lightsOff;
            }    
        }     

        private void button3_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                Printingarea print = new Printingarea(this);
                print.Show();
                Hide();
            }
            else
            {
                ScanningArea scan = new ScanningArea(this);
                scan.Show();
                Hide();
            }
        }
    }
}
