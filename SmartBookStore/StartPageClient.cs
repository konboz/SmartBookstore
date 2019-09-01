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
        public StartpageClient()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Library library = new Library(this);
        }
    }
}
