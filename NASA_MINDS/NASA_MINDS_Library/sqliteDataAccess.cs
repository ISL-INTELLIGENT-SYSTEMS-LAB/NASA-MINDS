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
            using (var con = new SQLiteConnection(LoadConnectionString()))
            {
                con.Open();

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
            using (var con = new SQLiteConnection(LoadConnectionString()))
            {
                con.Open();

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
            using (var con = new SQLiteConnection(LoadConnectionString()))
            {
                con.Open();

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

        public static List<Location> GetAllLocations()
        {
            // Open a connection to the database
            using (var con = new SQLiteConnection(LoadConnectionString()))
            {
                con.Open();

                //Create a command to select all locations from the database
                var cmd = new SQLiteCommand("SELECT * FROM Locations", con);
                SQLiteDataReader rdr = cmd.ExecuteReader();

                // Create a list of locations
                List<Location> locations = new List<Location>();

                // Read the data from the database and create a location object for each row
                while (rdr.Read())
                {
                    locations.Add(new Location(Convert.ToInt32(rdr["locationID"]),
                    rdr["locationName"].ToString(),
                    rdr["locationDescription"].ToString()));
                }

                // Close the connection to the database and return the list of locations
                rdr.Close();
                con.Close();
                return locations;
            }
        }



        public static void UpdateItem(int itemID, string itemName, string itemDescription, string serial, int conditionalStatus, string RN, string imageLocation, int RFID_Tag)
        {
            // Open a connection to the database
            using (var con = new SQLiteConnection(LoadConnectionString()))
            {
                con.Open();
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
            using (var con = new SQLiteConnection(LoadConnectionString()))
            {
                con.Open();

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
            using (var con = new SQLiteConnection(LoadConnectionString()))
            {
                con.Open();

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

        public static void InsertItem(string itemName, string itemDescription, string serial, int conditionalStatus, string RN, string imageLocation, string RFID_Tag)
        {
            // Open a connection to the database
            using (var con = new SQLiteConnection(LoadConnectionString()))
            {
                con.Open();

                //Create a command to insert the item into the database
                var cmd = new SQLiteCommand("INSERT INTO Items (itemName, itemDescription, serial, conditionalStatus, RN, imageLocation, RFID_Tag) VALUES (@itemName, @itemDescription, @serial, @conditionalStatus, @RN, @imageLocation, @RFID_Tag)", con);
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

        // Check existing tag ID
        public static bool CheckTagID(int tagID)
        {
            // Open a connection to the database
            using (var con = new SQLiteConnection(LoadConnectionString()))
            {
                con.Open();

                //Create a command to select the tag ID from the database
                var cmd = new SQLiteCommand("SELECT * FROM Items WHERE RFID_Tag=@tagID", con);
                cmd.Parameters.AddWithValue("@tagID", tagID);
                SQLiteDataReader rdr = cmd.ExecuteReader();

                // If the tag ID is found, return true
                if (rdr.HasRows)
                {
                    rdr.Close();
                    con.Close();
                    return true;
                }
                // If the tag ID is not found, return false
                else
                {
                    rdr.Close();
                    con.Close();
                    return false;
                }

            }

        }

        // Get item location ID, date, and account ID
        public static ItemLocation GetItemLocation(int itemID)
        {
            // Open a connection to the database
            using (var con = new SQLiteConnection(LoadConnectionString()))
            {
                con.Open();

                //Create a command to select the item location from the database
                var cmd = new SQLiteCommand("SELECT * FROM ItemLocation WHERE itemID=@itemID", con);
                cmd.Parameters.AddWithValue("@itemID", itemID);
                SQLiteDataReader rdr = cmd.ExecuteReader();

                // If the item location is not found, return null
                if (!rdr.HasRows)
                {
                    rdr.Close();
                    con.Close();
                    return null;
                }
                // Create an item location object from the data
                ItemLocation itemLocation;
                rdr.Read();
                itemLocation = new ItemLocation(Convert.ToInt32(rdr["recordID"]),
                                                Convert.ToInt32(rdr["itemID"]),
                                                Convert.ToInt32(rdr["locationID"]),
                                                Convert.ToInt32(rdr["accountID"]),
                                                rdr["recordDate"].ToString());
                rdr.Close();
                con.Close();
                return itemLocation;
            }
        }

        // Get specific items from the database
        public static Item GetItem(int itemID)
        {
            // Open a connection to the database
            using (var con = new SQLiteConnection(LoadConnectionString()))
            {
                con.Open();

                // Create a command to select the item from the database
                var cmd = new SQLiteCommand("SELECT * FROM Items WHERE itemID=@itemID", con);
                cmd.Parameters.AddWithValue("@itemID", itemID);
                SQLiteDataReader rdr = cmd.ExecuteReader();

                // If the item is not found, return null
                if (!rdr.HasRows)
                {
                    rdr.Close();
                    con.Close();
                    return null;
                }

                // Create an item object from the data
                Item item;
                rdr.Read();
                item = new Item(Convert.ToInt32(rdr["itemID"]),
                                                rdr["itemName"].ToString(),
                                                rdr["itemDescription"].ToString(),
                                                rdr["serial"].ToString(),
                                                Convert.ToInt32(rdr["conditionalStatus"]),
                                                rdr["RN"].ToString(),
                                                rdr["imageLocation"].ToString(),
                                                Convert.ToInt32(rdr["RFID_Tag"]));
                rdr.Close();
                con.Close();
                return item;
            }
        }
    }
}
