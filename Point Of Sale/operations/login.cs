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
                connect.reader = connect.command.ExecuteReader();
                if (result != null)
                {
                    String stringResult = result.ToString();
                    int userLevel = 11;
                    if (password.Equals(stringResult))
                    {
                        while (connect.reader.Read()) //if password is correct.
                        {
                            userLevel = Convert.ToInt32(connect.reader["user_level"]);
                        }
                        connect.close();
                        if (userLevel == 0)
                        {
                            return 10; // return 10 if admin.
                        }
                        else
                        {
                            return 11; //return 11 of cashier.
                        }
                         
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
