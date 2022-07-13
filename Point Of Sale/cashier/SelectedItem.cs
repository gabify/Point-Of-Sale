using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Point_Of_Sale.cashier
{
    public partial class SelectedItem : UserControl
    {
        public int ItemId { get; set; }
        public int _numOfOrders { get; set; }
        public string _itemName { get; set; }
        public float _itemPrice { get; set; }
        public float totalPrice { get; set; }
        public static SelectedItem instance;
        public SelectedItem(int itemId, int NumOfOrder, string itemName, float itemPrice, float totalPrice)
        {
            this.ItemId = itemId;
            this._numOfOrders = NumOfOrder;
            this._itemName = itemName;
            this._itemPrice = itemPrice;
            this.totalPrice = totalPrice;
            InitializeComponent();
            instance = this;
            lblNumOfOrder.Text = _numOfOrders.ToString();
            lblItemName.Text = itemName;
            lblitemPrice.Text = totalPrice.ToString();
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            float total = float.Parse(order.instance.total.Text.ToString());
            total -= totalPrice;
            order.instance.total.Text = total.ToString();
            order.instance.orders.Controls.Remove(this);
        }
    }
}
