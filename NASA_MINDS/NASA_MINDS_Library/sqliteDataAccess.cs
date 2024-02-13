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

                if (!rdr.HasRows)
                {
                    // Close the connection to the database and return null
                    rdr.Close();
                    con.Close();
                    return null;
                }

                // Create an account object from the data
                Account account;

                // Read the data from the database
                rdr.Read();
                // Create an account object from the data
                account = new Account(Convert.ToInt32(rdr["accountID"]), 
                                      rdr["username"].ToString(), 
                                      rdr["password"].ToString(), 
                                      rdr["title"].ToString(), 
                                      rdr["contact"].ToString(),
                                      rdr["picture"].ToString());
                rdr.Close();

                // Close the connection to the database and return the account object
                con.Close();
                return account;
            }
        }

        // Populate the datagridview for items
        public static Item PopulateData(string itemID)
        {
            // Open a connection to the database
            using (var con = new SQLiteConnection(LoadConnectionString())){con.Open();

                // Create a command to select the account from the database
                var cmd = new SQLiteCommand("SELECT * FROM Items WHERE ItemID=@itemID", con);
                cmd.Parameters.AddWithValue("@itemID", itemID);
                SQLiteDataReader rdr = cmd.ExecuteReader();

                // If the item is not found, return null
                if (!rdr.HasRows)
                {
                    // Close the connection to the database and return null
                    rdr.Close();
                    con.Close();
                    return null;
                }

                Item item;

                // Read the data from the database and create an item object
                rdr.Read();
                item = new Item(Convert.ToInt32(rdr["ItemID"]), 
                                rdr["itemName"].ToString(), 
                                rdr["itemDescription"].ToString(), 
                                rdr["serial"].ToString(), 
                                Convert.ToInt32(rdr["conditionalStatus"]), 
                                rdr["RN"].ToString(), 
                                rdr["imageLocation"].ToString(),
                                Convert.ToInt32(rdr["RFID_Tag"]));
                rdr.Close();

                // Close the connection to the database and return the item object
                con.Close();
                return item;
            }
        }
        
        public static List<Item> GetAllItems()
        {
            // Open a connection to the database
            using (var con = new SQLiteConnection(LoadConnectionString())){con.Open();

                // Create a command to select all items from the database
                var cmd = new SQLiteCommand("SELECT * FROM Items", con);
                SQLiteDataReader rdr = cmd.ExecuteReader();

                // Create a list of items
                List<Item> items = new List<Item>();
                //
                // Read the data from the database and create an item object for each row
                while (rdr.Read())
                {
                    items.Add(new Item(Convert.ToInt32(rdr["ItemID"]),
                                       rdr["itemName"].ToString(),
                                       rdr["itemDescription"].ToString(),
                                       rdr["serial"].ToString(),
                                       Convert.ToInt32(rdr["conditionalStatus"]),
                                       rdr["RN"].ToString(),
                                       rdr["imageLocation"].ToString(),
                                       Convert.ToInt32(rdr["RFID_Tag"])));

                }
                // Close the connection to the database and return the list of items
                rdr.Close();
                con.Close();
                return items;
            }
        }


        public static void UpdateItem(int itemID, string itemName, string itemDescription, string serial, int conditionalStatus, string RN, string imageLocation, int RFID_Tag) 
        {
            // Open a connection to the database
            using (var con = new SQLiteConnection(LoadConnectionString())){con.Open();

                // Create a command to update the item in the database
                var cmd = new SQLiteCommand("UPDATE Items SET itemName=@itemName, itemDescription=@itemDescription, serial=@serial, conditionalStatus=@conditionalStatus, RN=@RN, imageLocation=@imageLocation, RFID_Tag=@RFID_Tag WHERE itemID=@itemID", con);
                cmd.Parameters.AddWithValue("@itemID", itemID);
                cmd.Parameters.AddWithValue("@itemName", itemName);
                cmd.Parameters.AddWithValue("@itemDescription", itemDescription);
                cmd.Parameters.AddWithValue("@serial", serial);
                cmd.Parameters.AddWithValue("@conditionalStatus", conditionalStatus);
                cmd.Parameters.AddWithValue("@RN", RN);
                cmd.Parameters.AddWithValue("@imageLocation", imageLocation);
                cmd.Parameters.AddWithValue("@RFID_Tag", RFID_Tag);

                // Execute the command and close the connection to the database
                cmd.ExecuteNonQuery();
                con.Close();
                return;
            }
        }

        public static void UpdateAccount(int accountID, string username, string title, string contact, string picture)
        {
            // Open a connection to the database
            using (var con = new SQLiteConnection(LoadConnectionString())) { con.Open();
            
                // Create a command to update the account in the database
                var cmd = new SQLiteCommand("UPDATE Accounts SET username=@username, title=@title, contact=@contact, picture=@picture WHERE accountID=@accountID", con);
                cmd.Parameters.AddWithValue("@accountID", accountID);
                cmd.Parameters.AddWithValue("@username", username);
                //cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@title", title);
                cmd.Parameters.AddWithValue("@contact", contact);
                cmd.Parameters.AddWithValue("@picture", picture);

                // Execute the command and close the connection to the database
                cmd.ExecuteNonQuery();
                con.Close();
                return;
             }
        }

        public static void UpdatePassword(string username, string password)
        {
            // Open a connection to the database
            using (var con = new SQLiteConnection(LoadConnectionString())) { con.Open();
            
                           // Create a command to update the account in the database
                           var cmd = new SQLiteCommand("UPDATE Accounts SET Password=@password WHERE username=@username", con);
                           cmd.Parameters.AddWithValue("@username", username);
                           cmd.Parameters.AddWithValue("@password", password);
                         
                           // Execute the command and close the connection to the database
                           cmd.ExecuteNonQuery();
                           con.Close();
                           return;
            }           
        }
    }
}
