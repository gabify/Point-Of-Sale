using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using Point_Of_Sale.dbConnect;
using Point_Of_Sale.cashier;
using System.Collections;

namespace Point_Of_Sale.operations
{
    class item
    {
        public DataTable getItems()// get all items
        {
            Connection connect = new Connection();
            connect.open();
            using (connect.command = new MySqlCommand("getItems", connect.conn))
            {
                connect.command.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                connect.adapter = new MySqlDataAdapter();
                connect.adapter.SelectCommand = connect.command;
                connect.adapter.Fill(dt);
                connect.close();
                return dt;
            }
        }

        public List<Items> getMenuItems()
        {
            Connection connect = new Connection(); // init connection class
            connect.open(); // open connection
            using (connect.command = new MySqlCommand("getItems", connect.conn))// pass the sql query to the sql command builder
            {
                connect.command.CommandType = CommandType.StoredProcedure; //specify command type
                List<Items> items = new List<Items>(); // init list of items
                connect.reader = connect.command.ExecuteReader(); // execute query
                while (connect.reader.Read()) // read each item in the query result
                {
                    Items newItem = new Items(); // init new item
                    newItem.itemId = Convert.ToInt32(connect.reader["item_id"]);
                    newItem.itemName = connect.reader["item_name"].ToString();
                    newItem.itemcategory = connect.reader["category_name"].ToString();
                    newItem.itemPrice = float.Parse(connect.reader["item_price"].ToString());
                    newItem.itemImage = connect.reader["item_image"].ToString();

                    items.Add(newItem); // pass each item to the list of item
                }
                connect.close(); // close connection 
                return items; //return list of item
            }
        }

        public void addItems(string item_name, string item_category, float item_price, string item_image)// add items
        {
            Connection connect = new Connection();
            connect.open();
            using (connect.command = new MySqlCommand("add_item", connect.conn))
            {
                connect.command.CommandType = CommandType.StoredProcedure;
                connect.command.Parameters.AddWithValue("@itemName", item_name);
                connect.command.Parameters.AddWithValue("@itemCategory", getCategoryId(item_category));
                connect.command.Parameters.AddWithValue("@itemPrice", item_price);
                connect.command.Parameters.AddWithValue("@itemImage", item_image);
                connect.command.ExecuteNonQuery();
                connect.close();
            }
        }

        public void updateItems(string item_name, string item_category, float item_price, string item_image, int item_id)// update items
        {
            Connection connect = new Connection();
            connect.open();
            using (connect.command = new MySqlCommand("update_item", connect.conn))
            {
                connect.command.CommandType = CommandType.StoredProcedure;
                connect.command.Parameters.AddWithValue("@itemName", item_name);
                connect.command.Parameters.AddWithValue("@itemCategory", getCategoryId(item_category));
                connect.command.Parameters.AddWithValue("@itemPrice", item_price);
                connect.command.Parameters.AddWithValue("@itemImage", item_image);
                connect.command.Parameters.AddWithValue("@itemId", item_id);
                connect.command.ExecuteNonQuery();
                connect.close();
            }
        }

        public void deleteItems(int item_id)// delete items
        {
            Connection connect = new Connection();
            connect.open();
            using (connect.command = new MySqlCommand("delete_item", connect.conn))
            {
                connect.command.CommandType = CommandType.StoredProcedure;
                connect.command.Parameters.AddWithValue("@itemId", item_id);
                connect.command.ExecuteNonQuery();
                connect.close();
            }
        }

        public DataTable searchItem(string keyword)// search item
        {
            Connection connect = new Connection(); // initialized connection class
            connect.open(); // connect to the database
            using (connect.command = new MySqlCommand("search_item", connect.conn))//pass the sql query and connection string to the sql command builder
            {
                connect.command.CommandType = CommandType.StoredProcedure;// state the command type
                connect.command.Parameters.AddWithValue("@keyword", "%" + keyword + "%"); // add parameters to sql query
                DataTable dt = new DataTable(); // initialize datatable
                connect.adapter = new MySqlDataAdapter(); // initialize data adapter
                connect.adapter.SelectCommand = connect.command; // pass the sql command to data adapter
                connect.adapter.Fill(dt); // pass the result from the data adapter to the data table
                connect.close(); // close connection to the database
                return dt; // return result
            }
        }

        public ArrayList getCategories() //retrieve all categories
        {
            Connection connect = new Connection();
            connect.open();
            using (connect.command = new MySqlCommand("getCategories", connect.conn))
            {
                connect.command.CommandType = CommandType.StoredProcedure;
                ArrayList categories = new ArrayList();
                connect.reader = connect.command.ExecuteReader(); // pass the sql command to data reader
                while (connect.reader.Read()) // read the results from data reader
                {
                    categories.Add(connect.reader[0].ToString());// pass each result to the arraylist
                }
                connect.close();
                return categories; // return results

            }
        }

        private int getCategoryId(string category) // get the category id from database
        {
            Connection connect = new Connection();
            connect.open();
            using (connect.command = new MySqlCommand("getCategory_id", connect.conn))
            {
                connect.command.CommandType = CommandType.StoredProcedure;
                connect.command.Parameters.AddWithValue("@categoryName", category);
                int result = Convert.ToInt32(connect.command.ExecuteScalar());
                connect.close();
                return result;
            }
        }
    }
}
