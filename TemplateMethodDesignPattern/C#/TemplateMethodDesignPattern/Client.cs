using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodDesignPattern
{
    class Client
    {
        public static void ClientCode(AbstractClass abstractClass)
        {
            abstractClass.TemplateMethod();
        }
    }
}
