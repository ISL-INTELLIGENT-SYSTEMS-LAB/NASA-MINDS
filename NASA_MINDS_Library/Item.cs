using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NASA_MINDS_Library
{
    public class Item
    {
        // Constructor for database items
        public Item(int itemID, string itemName, string itemDescription, string serialNum, int condition, string RNNumber, string image_loc, int RFIDnum) 
        {
            ItemID = itemID;
            ItemName = itemName;
            ItemDescription = itemDescription;
            SerialNum = serialNum;
            Condition = condition;
            RNNum = RNNumber;
            Image_loc = image_loc;
            RFID = RFIDnum;
        }

        // Properties for the item object
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public string ItemDescription { get; set; }
        public string SerialNum { get; set; }
        public int Condition { get; set; }
        public string RNNum { get; set; }
        public string Image_loc { get; set; }
        public int RFID { get; set; }
    }

    public class ItemLocation
    {
        // Constructor for the item location
        public ItemLocation(int recordid, int itemID, int locationid, int accountid, string date)
        {
            RecordID = recordid;
            ItemID = itemID;
            Location = locationid;
            AccountID = accountid;
            Date = date;
        }

        // Properties for the item location
        public int RecordID { get; set; }
        public int ItemID { get; set; }
        public int Location { get; set; }
        public int AccountID { get; set; }
        public string Date { get; set; }
    }


}

