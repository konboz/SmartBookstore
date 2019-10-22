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
    public partial class Cart : Form
    {
        Form form;
        decimal sum;
        public Cart(Form form)
        {
            InitializeComponent();
            this.form = form;
            LoadGrid();
            dataGridView1.CellClick += dataGridView1_CellClick;
            label2.Text = sum.ToString() + "ευρώ";
        }

        private void LoadGrid()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Τίτλος", typeof(string));
            dt.Columns.Add("Συγγραφέας", typeof(string));
            dt.Columns.Add("Τιμή", typeof(string));
            sum = 0;
            foreach (var book in GlobalVariables.cart.Books)
            {
                dt.Rows.Add(book.Title, book.Author, book.Price.ToString());
                sum += book.Price;
            }
            dataGridView1.DataSource = dt;

            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.DefaultCellStyle.BackColor = Color.Red;
            deleteButtonColumn.Name = "Διαγραφή";
            deleteButtonColumn.Text = "Διαγραφή";
            int columnIndex = 3;
            if (dataGridView1.Columns["Διαγραφή"] == null)
            {
                dataGridView1.Columns.Insert(columnIndex, deleteButtonColumn);
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Διαγραφή"].Index)
            {
                var grid = sender as DataGridView;
                var row = grid.CurrentRow.Index;
                var title = dataGridView1.Rows[row].Cells[1].FormattedValue.ToString();
                Utilities.BookDelete(title);
                LoadGrid();
                label2.Text = sum.ToString() + "ευρώ";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var order = new Order(this, sum);
            order.Show();
            Hide();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            form.Show();
            Hide();
        }

        private void Cart_Load(object sender, EventArgs e)
        {
            
        }
    }
}
