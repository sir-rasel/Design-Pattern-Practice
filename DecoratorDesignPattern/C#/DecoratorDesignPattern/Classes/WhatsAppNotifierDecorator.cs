using DecoratorDesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorDesignPattern.Classes
{
    class WhatsAppNotifierDecorator : BaseNotifierDecorator, INotifier
    {
        public WhatsAppNotifierDecorator(INotifier wrapped) : base(wrapped) { }

        public void Send(string message)
        {
            base.Send(message);

            string phone = DatabaseService.GetPhoneNbrFromUsername(GetUserName());
            Console.WriteLine("Sending " + message + " to the whatsapp " + phone);
        }
    }
}
