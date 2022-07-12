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
        int ItemId;
        int _numOfOrders;
        string _itemName;
        float _itemPrice;
        public static SelectedItem instance;
        public SelectedItem(int itemId, int NumOfOrder, string itemName, float itemPrice)
        {
            this.ItemId = itemId;
            this._numOfOrders = NumOfOrder;
            this._itemName = itemName;
            this._itemPrice = itemPrice;
            InitializeComponent();
            instance = this;
            lblNumOfOrder.Text = _numOfOrders.ToString();
            lblItemName.Text = itemName;
            lblitemPrice.Text = itemPrice.ToString();
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            float total = float.Parse(order.instance.total.Text.ToString());
            total -= _itemPrice;
            order.instance.total.Text = total.ToString();
            order.instance.orders.Controls.Remove(this);
        }
    }
}
