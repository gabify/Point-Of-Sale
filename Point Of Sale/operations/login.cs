using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Point_Of_Sale.dbConnect;
using MySql.Data.MySqlClient;

namespace Point_Of_Sale.operations
{
    class login
    {

        public int userLogin(string uname, String password)
        {
            Connection connect = new Connection();
            connect.open();
            using (connect.command = new MySqlCommand("login", connect.conn))
            {
                connect.command.CommandType = CommandType.StoredProcedure;
                connect.command.Parameters.AddWithValue("@uname", uname);
                object result = connect.command.ExecuteScalar();
                connect.close();
                if (result != null)
                {
                    String stringResult = result.ToString();
                    if (password.Equals(stringResult))
                    {
                        return 1; // return 1 if password is correct.
                    }
                    else
                    {
                        return 2; //return 2 if password is incorrect.
                    }
                }
                else
                {
                    return 0; // return 0 if username does not exist.
                }
            }
        }

        public Boolean ifEmpty(string val)
        {
            if (val.Equals(""))
            {
                return true; // return true if val is empty string
            }
            else
            {
                return false; // return false if val is not empty string
            }
        }
    }
}
