using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using Point_Of_Sale.dbConnect;
using System.Data;

namespace Point_Of_Sale.operations
{
    class category
    {
        public DataTable getCategory() //return all categories
        {
            Connection connect = new Connection();
            connect.open();
            using (connect.command = new MySqlCommand("getCategory", connect.conn))
            {
                connect.command.CommandType = CommandType.StoredProcedure;
                connect.adapter = new MySqlDataAdapter();
                connect.adapter.SelectCommand = connect.command;
                DataTable dt = new DataTable();
                connect.adapter.Fill(dt);
                connect.close();
                return dt;
            }
        }

        public void addCategory(string category_name)// add category
        {
            Connection connect = new Connection();
            connect.open();
            using (connect.command = new MySqlCommand("add_category", connect.conn))
            {
                connect.command.CommandType = CommandType.StoredProcedure;
                connect.command.Parameters.AddWithValue("@cat_name", category_name);
                connect.command.Parameters.AddWithValue("@cat_date", DateTime.Now);
                connect.command.ExecuteNonQuery();
                connect.close();
            }
        }

        public void updateCategory(string category_name)// update category
        {
            Connection connect = new Connection();
            using (connect.command = new MySqlCommand("update_category", connect.conn))
            {
                connect.command.CommandType = CommandType.StoredProcedure;
                connect.command.Parameters.AddWithValue("@cat_name", category_name);
                connect.open();
                connect.command.ExecuteNonQuery();
                connect.close();
            }
        }
    }
}
