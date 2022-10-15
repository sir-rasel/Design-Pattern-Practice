using AbstractFactoryDesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern.Classes
{
    class AsusGpu : IGPU
    {
        public void Assemble()
        {
            Console.WriteLine("Asus GPU");
        }
    }
}
