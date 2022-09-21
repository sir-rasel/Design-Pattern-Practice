using DecoratorDesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorDesignPattern.Classes
{
    class FacebookNotifierDecorator : BaseNotifierDecorator, INotifier
    {
        public FacebookNotifierDecorator(INotifier wrapped) : base(wrapped) { }

        public void Send(string message)
        {
            base.Send(message);

            string facebook = DatabaseService.GetFBNameFromUsername(GetUserName());
            Console.WriteLine("Sending " + message + " to the facebook " + facebook);
        }
    }
}
