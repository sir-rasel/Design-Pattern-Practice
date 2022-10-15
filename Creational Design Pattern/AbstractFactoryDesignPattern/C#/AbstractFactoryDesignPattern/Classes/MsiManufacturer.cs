using AbstractFactoryDesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern.Classes
{
    class MsiManufacturer : AbstractFactory
    {
        public override IGPU CreateGpu()
        {
            return new MsiGpu();
        }

        public override IMonitor CreateMonitor()
        {
            return new MsiMonitor();
        }
    }
}
