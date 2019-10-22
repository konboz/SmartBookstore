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
    public partial class Radio : Form
    {
        public Form form;
        public Radio(Form form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://bbcmedia.ic.llnwd.net/stream/bbcmedia_6music_mf_p";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://media-ice.musicradio.com:80/ClassicFMMP3";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            form.Show(this);
            Hide();
        }
    }
}
