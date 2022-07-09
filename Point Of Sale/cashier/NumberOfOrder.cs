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
    public partial class NumberOfOrder : Form
    {
        int _numberOfOrder;
        string _itemName;
        float _itemPrice;
        public event EventHandler<OrderEventArgs> OrderedConfirmed;
        ItemSelected itemSelected = new ItemSelected();
        public NumberOfOrder(string itemName, float itemPrice)
        {
            this._itemName = itemName;
            this._itemPrice = itemPrice;
            InitializeComponent();
            ItemSelected
            lblTitle.Text = "How many orders of " + _itemName + " ?";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            _numberOfOrder = Convert.ToInt32(txtNumberOfOrder.Text);
            OrderedItem order = new OrderedItem(_numberOfOrder, _itemName, _itemPrice);
            OnOrderedConfirmed(order);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        protected virtual void OnOrderedConfirmed( OrderedItem orderedItem)
        {
            OrderedConfirmed?.Invoke(this, new OrderEventArgs() { order = orderedItem});
        }
    }

    public class OrderEventArgs : EventArgs
    {
        public OrderedItem order { get; set; }
    }

    public class OrderedItem
    {
        public int NumberOforder;
        public string ItemName;
        public float ItemPrice;

        public OrderedItem(int numberOfOrder, string itemName, float itemPrice)
        {
            this.NumberOforder = numberOfOrder;
            this.ItemName = itemName;
            this.ItemPrice = itemPrice;
            
        }
    }

    public class ItemSelected
    {
        public void onItemSelected(Object source, SelectedItemArgs e)
        {
            //pass data to main class
        }
    }
}
