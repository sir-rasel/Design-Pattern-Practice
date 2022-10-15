using DecoratorDesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorDesignPattern.Classes
{
    class EmailNotifier : INotifier
    {
        public string UserName { get; set; }
        public DatabaseService DatabaseService { get; set; }

        public EmailNotifier(string username)
        {
            UserName = username;
            DatabaseService = new DatabaseService();
        }

        public string GetUserName()
        {
            return UserName;
        }

        public void Send(string message)
        {
            string email = DatabaseService.GetMailFromUsername(UserName);
            Console.WriteLine("Sending " + message  + " to mail : " + email);
        }
    }
}
