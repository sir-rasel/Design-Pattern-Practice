using System;
using System.Collections.Generic;
using System.Text;

namespace FacadeDesignPattern
{
    class Client
    {
        public static void ClientCode(Facade facade)
        {
            Console.Write(facade.Operation());
        }
    }
}
