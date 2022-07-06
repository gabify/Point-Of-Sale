using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Point_Of_Sale.operations;

namespace Point_Of_Sale.admin
{
    public partial class add_category : Form
    {
        category cat = new category();
        public add_category()
        {
            InitializeComponent();
        }

        private void add_category_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cat.addCategory(txtCategory_name.Text);
            refresh();
        }

        private void refresh()
        {
            dgv_category.Refresh();
            dgv_category.DataSource = cat.getCategory();
            txtCategory_name.Text = "";
            txtCategory_date.Text = "";
        }

        private void dgv_category_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCategory_name.Text = dgv_category.CurrentRow.Cells[1].Value.ToString();
            txtCategory_date.Text = dgv_category.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refresh();
        }
    }
}
