using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Point_Of_Sale.operations;
using Point_Of_Sale.cashier;
using System.Collections;


namespace Point_Of_Sale.cashier
{
    public partial class menu_item : UserControl
    {
        Items newItem = new Items();
        public menu_item(int itemId, string itemName, string itemCategory, float itemPrice, string itemImage)
        {
            newItem.itemId = itemId;
            newItem.itemName = itemName;
            newItem.itemcategory = itemCategory;
            newItem.itemPrice = itemPrice;
            newItem.itemImage = itemImage;
            InitializeComponent();
            lbl_item_name.Text = newItem.itemName;
            lbl_item_category.Text = newItem.itemcategory;
            lbl_item_price.Text = newItem.itemPrice.ToString();

            if (newItem.itemImage == "") //check if the item has an image
            {
                pb_item_image.Image = null; //set to default
            }
            else
            {
                pb_item_image.Image = new Bitmap(newItem.itemImage); //set the item image
            }
        }

        private void menu_item_Load(object sender, EventArgs e)
        {
            
        }

        private void menu_item_MouseClick(object sender, MouseEventArgs e)
        {
            NumberOfOrder form = new NumberOfOrder();
            form.ItemName = newItem.itemName;
            form.ItemPrice = newItem.itemPrice;
            form.itemId = newItem.itemId;
            form.Show();
        }
    }

}
