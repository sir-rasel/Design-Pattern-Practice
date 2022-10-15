using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorDesignPattern.Classes
{
    public class DatabaseService
    {
        public string GetMailFromUsername(string username)
        {
            return username + "@Mail";
        }

        public string GetPhoneNbrFromUsername(string username)
        {
            return username + "@Phone";
        }

        public string GetFBNameFromUsername(string username)
        {
            return username + "@Facebook";
        }
    }
}
