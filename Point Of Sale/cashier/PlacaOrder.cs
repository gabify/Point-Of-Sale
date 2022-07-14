using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Point_Of_Sale.cashier
{
    public partial class PlacaOrder : Form
    {
        float totalDue;
        List<OrderedItem> orders;
        public PlacaOrder(List<OrderedItem> orders, float totalDue)
        {
            this.orders = orders;
            this.totalDue = totalDue;
            InitializeComponent();
            lblTotalDue.Text = totalDue.ToString();
            loadOrders();
        }

        private void loadOrders()
        {
            dgvorderList.DataSource = orders;
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Order placed successfully. Please wait for your order to served");
        }
    }


}
