using System;

namespace FacadeDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            SubSystem1 subsystem1 = new SubSystem1();
            SubSystem2 subsystem2 = new SubSystem2();
            Facade facade = new Facade(subsystem1, subsystem2);
            Client.ClientCode(facade);
        }
    }
}