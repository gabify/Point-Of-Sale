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
        int _numOfOrders;
        string _itemName;
        float _itemPrice;
        public SelectedItem(int NumOfOrder, string itemName, float itemPrice)
        {
            this._numOfOrders = NumOfOrder;
            this._itemName = itemName;
            this._itemPrice = itemPrice;
            InitializeComponent();
            lblNumOfOrder.Text = _numOfOrders.ToString();
            lblItemName.Text = itemName;
            lblitemPrice.Text = itemPrice.ToString();
        }
    }
}
