using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoObjectorienteringIntroduktion.Class
{
    public class User
    {
        //För att skapa en property skriv prop+<tab
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        //För att skapa en tom konstruktor skriv ctor+ tab

        public User()
        {
            
        }

        //För att skapa en konstruktor med värden skriv ctrl+.
        public User(string username, string password, string email)
        {
            Username = username;
            Password = password;
            Email = email;
        }

        //En metod som gör någonting
        public void Save()
        {
            
        }

        public bool Login()
        {
            //
            return true;
        }



    }

   
}
