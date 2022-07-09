using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_Of_Sale.cashier
{
    class Items
    {
        private int item_id;
        private string item_name;
        private string item_category;
        private float item_price;
        private string item_image;

        public int itemId
        {
            get { return item_id; }
            set { item_id = value; }
        }

        public string itemName
        {
            get { return item_name; }
            set { item_name = value; }
        }

        public string itemcategory
        {
            get { return item_category; }
            set { item_category = value; }
        }

        public float itemPrice
        {
            get { return item_price; }
            set { item_price = value; }
        }

        public string itemImage
        {
            get { return item_image; }
            set { item_image = value; }
        }

    }
}
