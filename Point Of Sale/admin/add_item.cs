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
        string image_filename;
        int itemId;
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

        private void add_item_Load(object sender, EventArgs e) // form load
        {
            refresh();
        }

        private void btnAdd_Click(object sender, EventArgs e)// add button
        {
            items.addItems(txtItem_name.Text, cb_item_category.SelectedItem.ToString(), float.Parse(txtPrice.Text),image_filename);
            refresh();
        }

        private void btnAddImage_Click(object sender, EventArgs e)// add image to picture box
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files (*.jpg; *.png; *.gif)| *.jpeg; *.PNG; *.gif";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pbItem_picture.Image = new Bitmap(open.FileName);
                image_filename = open.FileName;
            }
        }

        private void dgvItem_CellClick(object sender, DataGridViewCellEventArgs e) // cell click
        {
            itemId = Convert.ToInt32(dgvItem.CurrentRow.Cells[0].Value);
            txtItem_name.Text = dgvItem.CurrentRow.Cells[1].Value.ToString();
            txtPrice.Text = dgvItem.CurrentRow.Cells[3].Value.ToString();
            cb_item_category.Text = dgvItem.CurrentRow.Cells[2].Value.ToString();
            if (dgvItem.CurrentRow.Cells[4].Value.ToString() == "")
            {
                pbItem_picture.Image = null;
            }
            else
            {
                pbItem_picture.Image = new Bitmap(dgvItem.CurrentRow.Cells[4].Value.ToString());
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e) // update button
        {
            items.updateItems(txtItem_name.Text, cb_item_category.SelectedItem.ToString(), float.Parse(txtPrice.Text), image_filename, itemId);
            refresh();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to delete this item?", "Warning", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                items.deleteItems(itemId);
                refresh();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            dgvItem.Refresh();
            dgvItem.DataSource = items.searchItem(txtSearch.Text);
        }
    }
}
