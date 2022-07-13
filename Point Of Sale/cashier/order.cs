using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Point_Of_Sale.operations;
using Point_Of_Sale.cashier;
using System.Windows.Forms;
using System.Collections;

namespace Point_Of_Sale.cashier
{
    public partial class order : Form
    {
        public static order instance;
        public FlowLayoutPanel orders;
        public Label total;
        public order()
        {
            InitializeComponent();
            instance = this;
            orders = selectedOrderLayout;
            total = lblTotalorder;
        }

        private void populateMenuItems()
        {
            item Item = new item(); //init class for needed in getting all menu items
            List<Items> item = Item.getMenuItems(); //pass the menu items to the list

            foreach (Items newItem in item) //iterate the list
            {
                menu_item newMenuItem = new menu_item(newItem.itemId, newItem.itemName, newItem.itemcategory, newItem.itemPrice, newItem.itemImage); //pass the properties of each object to menu item user control
                if (menu_layout.Controls.Count < 0) // check if the user controls are empty
                {
                    menu_layout.Controls.Clear(); // set default operation if there is no user control
                }
                else
                {
                    menu_layout.Controls.Add(newMenuItem); //add menu items to the flow layout
                }
            }

        }

        private void order_Load(object sender, EventArgs e)
        {
            populateMenuItems();
        }

        private void btnClearOrders_Click(object sender, EventArgs e)
        {
            selectedOrderLayout.Controls.Clear();
            lblTotalorder.Text = "";
        }

        private void btnPlaceorder_Click(object sender, EventArgs e)
        {
            List<OrderedItem> ordersList = new List<OrderedItem>();
            foreach (SelectedItem order in selectedOrderLayout.Controls.OfType<SelectedItem>())
            {
                OrderedItem item = new OrderedItem();
                item.itemId = order.ItemId;
                item.quantity = order._numOfOrders;
                item.itemName = order._itemName;
                item.itemPrice = order._itemPrice;
                item.totalItemPrice = order.totalPrice;
                ordersList.Add(item);
            }
            PlacaOrder form = new PlacaOrder(ordersList, float.Parse(lblTotalorder.Text.ToString()));
            form.Show();
        }
    }

    public class OrderedItem
    {
        public int itemId { get; set; }
        public int quantity { get; set; }
        public string itemName { get; set; }
        public float itemPrice { get; set; }
        public float totalItemPrice { get; set; }
    }
}
