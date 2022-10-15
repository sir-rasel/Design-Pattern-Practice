using SimpleFactoryDesignPattern.Classes;
using System;

namespace SimpleFactoryDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            client.PlaceOrder("B");
        }
    }
}
