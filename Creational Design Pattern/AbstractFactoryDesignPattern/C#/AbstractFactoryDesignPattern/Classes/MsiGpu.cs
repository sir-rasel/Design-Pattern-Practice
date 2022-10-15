using AbstractFactoryDesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern.Classes
{
    class MsiGpu : IGPU
    {
        public void Assemble()
        {
            Console.WriteLine("Msi GPU");
        }
    }
}
