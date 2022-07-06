using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Point_Of_Sale.dbConnect
{
    class Connection
    {
        public MySqlConnection conn;
        public MySqlCommand command;
        public MySqlDataAdapter adapter;
        public MySqlDataReader reader;
        private string connectionString = "server=localhost;uid=personalUser;pwd=@talacs_12535;database=posdata";



        //connect to database
        public void open()
        {
            conn = new MySqlConnection();
            conn.ConnectionString = connectionString;
            conn.Open();
        }

        //close connection
        public void close()
        {
            conn.Close();
        }

        public string getConnection()
        {
            return connectionString;
        }
    }
}
