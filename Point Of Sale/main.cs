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
            addCategory.Show();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            add_item addItem = new add_item();
            addItem.Show();
        }
    }
}
