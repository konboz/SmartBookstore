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
        public Radio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://bbcmedia.ic.llnwd.net/stream/bbcmedia_6music_mf_p";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://media-ice.musicradio.com:80/ClassicFMMP3";
        }
    }
}
