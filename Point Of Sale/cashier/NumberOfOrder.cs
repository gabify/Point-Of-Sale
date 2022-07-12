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
        float total;
        private string _itemName;
        private float _itemPrice;
        private int ItemId;
        public static NumberOfOrder instance;
        public NumberOfOrder()
        {
            InitializeComponent();
            instance = this;
        }

        private void confirm()
        {
            _numberOfOrder = Convert.ToInt32(txtNumberOfOrder.Text);
            SelectedItem selectedItem = new SelectedItem(ItemId, _numberOfOrder, _itemName, _itemPrice);
            if (order.instance.orders.Controls.Count < 0)
            {
                order.instance.orders.Controls.Clear();
            }
            else
            {
                order.instance.orders.Controls.Add(selectedItem);
                computeTotal();
            }
        }

        private void computeTotal()
        {
            if (String.IsNullOrEmpty(order.instance.total.Text.ToString()))
            {
                total = 0.0f;
            }
            else
            {
                total = float.Parse(order.instance.total.Text.ToString());
            }
            total += _itemPrice;
            order.instance.total.Text = total.ToString();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            confirm();
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        
        public string ItemName
        {
            get { return _itemName; }
            set { _itemName = value; }
        }

        
        public float ItemPrice
        {
            get { return _itemPrice; }
            set { _itemPrice = value; }
        }

        public int itemId
        {
            get { return ItemId; }
            set { ItemId = value; }
        }


        private void NumberOfOrder_Load(object sender, EventArgs e)
        {
            lblTitle.Text = "How many orders of " + _itemName + " ?";
        }
    }
}
