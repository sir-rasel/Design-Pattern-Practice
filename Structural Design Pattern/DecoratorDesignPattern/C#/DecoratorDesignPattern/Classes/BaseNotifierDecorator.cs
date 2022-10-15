using DecoratorDesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorDesignPattern.Classes
{
    public abstract class BaseNotifierDecorator : INotifier
    {
        private readonly INotifier Wrapped;
        protected readonly DatabaseService DatabaseService;

        public BaseNotifierDecorator(INotifier wrapped)
        {
            Wrapped = wrapped;
            DatabaseService = new DatabaseService();
        }

        public void Send(string msg)
        {
            Wrapped.Send(msg);
        }

        public string GetUserName()
        {
            return Wrapped.GetUserName();
        }
    }
}
