using AbstractFactoryDesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern.Classes
{
    class AsusManufacturer : AbstractFactory
    {
        public override IGPU CreateGpu()
        {
            return new AsusGpu();
        }

        public override IMonitor CreateMonitor()
        {
            return new AsusMonitor();
        }
    }
}
