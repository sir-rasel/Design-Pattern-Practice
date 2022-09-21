using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorDesignPattern.Interfaces
{
    public interface INotifier
    {
        public void Send(string message);
        public string GetUserName();
    }
}
