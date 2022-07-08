using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using Point_Of_Sale.dbConnect;

namespace Point_Of_Sale.operations
{
    class cashier
    {
        public void addCashier(string[] data) // add cashier
        {
            addCashierDetail(data); // insert cashier's detail and user info
            addCashierRef(getMaxCashier(), getMaxUser()); //insert cashier reference
        }

        public void updateCashierDetail(string[] data, int cashierDetailId, int userId) // update cashier detail
        {
            Connection connect = new Connection(); // initialize Connection class
            connect.open(); // open connection
            using (connect.command = new MySqlCommand("add_cashier", connect.conn)) // initialized sql command and pass the sql query
            {
                connect.command.CommandType = CommandType.StoredProcedure; //set the procedure type
                connect.command.Parameters.AddWithValue("@cashierFirstName", data[0]);
                connect.command.Parameters.AddWithValue("@cashierMiddleName", data[1]);
                connect.command.Parameters.AddWithValue("@cashierLastName", data[2]);
                connect.command.Parameters.AddWithValue("@cashierGender", data[3]);      // add parameters to the sql query
                connect.command.Parameters.AddWithValue("@cashierImage", data[4]);
                connect.command.Parameters.AddWithValue("@cashier_detailId", cashierDetailId);
                connect.command.Parameters.AddWithValue("@cashierUsername", data[5]);
                connect.command.Parameters.AddWithValue("@cashierPassword", data[6]);
                connect.command.Parameters.AddWithValue("@userId", userId); 
                connect.command.ExecuteNonQuery(); // execute query
                connect.close(); // close connection
            }
        }

        public void deleteCashier(int cashierId) // delete cashier
        {
            Connection connect = new Connection(); // initialize Connection class
            connect.open(); // open connection
            using (connect.command = new MySqlCommand("delete_cashier", connect.conn))
            {
                connect.command.CommandType = CommandType.StoredProcedure; //set the procedure type
                connect.command.Parameters.AddWithValue("@cashierId", cashierId); // add parameters
                connect.command.ExecuteNonQuery(); // execute query
                connect.close(); // close connection
            }
        }

        public DataTable getCashier() // get all cashiers
        {
            Connection connect = new Connection(); // initialize Connection class
            connect.open(); // open connection
            using (connect.command = new MySqlCommand("getCashiers", connect.conn))
            {
                connect.command.CommandType = CommandType.StoredProcedure; //set the procedure type
                DataTable dt = new DataTable(); // init data table
                connect.adapter = new MySqlDataAdapter(); //init data adapter
                connect.adapter.SelectCommand = connect.command; // pass the sql query and connection to data adapter
                connect.adapter.Fill(dt); // pass the result of sql query to data table
                connect.close(); // close connection
                return dt; //return  data table
            }
        }

        private void addCashierDetail(string[] data) // add cashier detail
        {
            Connection connect = new Connection(); // initialize Connection class
            connect.open(); // open connection
            using (connect.command = new MySqlCommand("add_cashier_detail", connect.conn)) // initialized sql command and pass the sql query
            {
                connect.command.CommandType = CommandType.StoredProcedure; //set the procedure type
                connect.command.Parameters.AddWithValue("@cashierFirstName", data[0]);
                connect.command.Parameters.AddWithValue("@cashierMiddleName", data[1]);
                connect.command.Parameters.AddWithValue("@cashierLastName", data[2]);
                connect.command.Parameters.AddWithValue("@cashierGender", data[3]);      // add parameters to the sql query
                connect.command.Parameters.AddWithValue("@cashierImage", data[4]);
                connect.command.Parameters.AddWithValue("@cashierUsername", data[5]);
                connect.command.Parameters.AddWithValue("@cashierPassword", data[6]);
                connect.command.ExecuteNonQuery(); // execute query
                connect.close(); // close connection
            }
        }

        private int getMaxCashier() //get max cashier
        {
            Connection connect = new Connection(); // initialize Connection class
            connect.open(); // open connection
            using (connect.command = new MySqlCommand("getMaxCashierDetail", connect.conn)) // initialized sql command and pass the sql query
            {
                connect.command.CommandType = CommandType.StoredProcedure; //set the procedure type
                int result = Convert.ToInt32(connect.command.ExecuteScalar()); // execute query
                connect.close(); // close connection
                return result;
            }
        }

        private int getMaxUser() //get max cashier
        {
            Connection connect = new Connection(); // initialize Connection class
            connect.open(); // open connection
            using (connect.command = new MySqlCommand("getMaxUser", connect.conn)) // initialized sql command and pass the sql query
            {
                connect.command.CommandType = CommandType.StoredProcedure; //set the procedure type
                int result = Convert.ToInt32(connect.command.ExecuteScalar()); // execute query
                connect.close(); // close connection
                return result;
            }
        }

        private void addCashierRef(int maxCashierDetail, int maxUser) // add cashier reference table
        {
            Connection connect = new Connection(); // initialize Connection class
            connect.open(); // open connection
            using (connect.command = new MySqlCommand("add_cashier", connect.conn)) // initialized sql command and pass the sql query
            {
                connect.command.CommandType = CommandType.StoredProcedure; //set the procedure type
                connect.command.Parameters.AddWithValue("@cashier_detailId", maxCashierDetail + 1);
                connect.command.Parameters.AddWithValue("@userId", maxUser + 1); // add parameters to the sql query
                connect.command.ExecuteNonQuery(); // execute query
                connect.close(); // close connection
            }
        }
    }
}
