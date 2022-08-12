using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Point_Of_Sale.admin;
using Point_Of_Sale.cashier;

namespace Point_Of_Sale
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void add_category_Click(object sender, EventArgs e)
        {
            add_category addCategory = new add_category();
            addCategory.TopLevel = false;
            addCategory.AutoScroll = true;
            mainPanel.Controls.Add(addCategory);
            addCategory.Show();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            add_item addItem = new add_item();
            addItem.TopLevel = false;
            addItem.AutoScroll = true;
            mainPanel.Controls.Add(addItem);
            addItem.Show();
        }

        private void btnAddCashier_Click(object sender, EventArgs e)
        {
            add_cashier addCashier = new add_cashier();
            addCashier.TopLevel = false;
            addCashier.AutoScroll = true;
            mainPanel.Controls.Add(addCashier);
            addCashier.Show();
        }

        private void btnViewCashier_Click(object sender, EventArgs e)
        {
            view_cashier viewCashier = new view_cashier();
            viewCashier.TopLevel = false;
            viewCashier.AutoScroll = true;
            mainPanel.Controls.Add(viewCashier);
            viewCashier.Show();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            order newOrder = new order();
            newOrder.Show();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
