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
        private int _itemId;
        private string _itemName, _itemCategory, _itemImage;
        private float _itemPrice;
        public menu_item(int itemId, string itemName, string itemCategory, float itemPrice, string itemImage)
        {
            this._itemId = itemId;
            this._itemName = itemName;
            this._itemCategory = itemCategory;
            this._itemPrice = itemPrice;
            this._itemImage = itemImage;
            InitializeComponent();
            lbl_item_name.Text = _itemName;
            lbl_item_category.Text = _itemCategory;
            lbl_item_price.Text = _itemPrice.ToString();

            if (_itemImage == "") //check if the item has an image
            {
                pb_item_image.Image = null; //set to default
            }
            else
            {
                pb_item_image.Image = new Bitmap(_itemImage); //set the item image
            }
        }

        private void menu_item_Load(object sender, EventArgs e)
        {
            
        }
    }
}
