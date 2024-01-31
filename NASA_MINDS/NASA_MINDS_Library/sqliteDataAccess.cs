using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SQLite;

namespace NASA_MINDS_Library
{
    public class sqliteDataAccess
    {
        // Load the connection string from the App.config file
        private static string LoadConnectionString(string id = "Default")
        {
            // Return the connection string
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        // Retrieve an account from the database
        public static Account RetriveAccount(string username)
        {
            // Open a connection to the database
            using (var con = new SQLiteConnection(LoadConnectionString())){con.Open();

                // Create a command to select the account from the database
                var cmd = new SQLiteCommand("SELECT * FROM Accounts WHERE username=@username", con); 
                cmd.Parameters.AddWithValue("@username", username);
                SQLiteDataReader rdr = cmd.ExecuteReader();

                // Create an account object from the data
                Account account;

                // Read the data from the database
                rdr.Read();
                // Create an account object from the data
                account = new Account(Convert.ToInt32(rdr["accountID"]), rdr["username"].ToString(), rdr["password"].ToString(), rdr["title"].ToString(), rdr["contact"].ToString());
                rdr.Close();

                // Close the connection to the database and return the account object
                con.Close();
                return account;

            }
        }
    }
}
