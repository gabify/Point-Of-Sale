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
    public partial class add_item : Form
    {
        item items = new item();
        public add_item()
        {
            InitializeComponent();
        }

        private void refresh()
        {
            dgvItem.Refresh();
            dgvItem.DataSource = items.getItems();
            cb_item_category.DataSource = items.getCategories();
            txtItem_name.Text = "";
            txtSearch.Text = "";
            txtPrice.Text = "";
            pbItem_picture.Image = null;
            
        }

        private void add_item_Load(object sender, EventArgs e)
        {
            refresh();
        }
    }
}
