using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NASA_MINDS_Library
{
    public class Account
    {
        // Constructor for the Account class
        public Account(int accountID, string username, string password, string title, string contact) 
        { 
            AccountID = accountID;
            Username = username;
            Password = password;
            Title = title;
            Contact = contact;
        }

        // Properties for the Account class
        public int AccountID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Title { get; set; }
        public string Contact { get; set; }
    }
}
