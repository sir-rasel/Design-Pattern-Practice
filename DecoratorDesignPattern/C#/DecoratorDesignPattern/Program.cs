using DecoratorDesignPattern.Classes;
using DecoratorDesignPattern.Interfaces;
using System;

namespace DecoratorDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            INotifier notifyAll = new FacebookNotifierDecorator(new WhatsAppNotifierDecorator(new EmailNotifier("SIR")));
            notifyAll.Send("Like and Subscribe!!!");

            Console.WriteLine("==========================================");

            INotifier notifyFbMail = new FacebookNotifierDecorator(new EmailNotifier("sir"));
            notifyFbMail.Send("Like and Subscribe!!!");
        }
    }
}
