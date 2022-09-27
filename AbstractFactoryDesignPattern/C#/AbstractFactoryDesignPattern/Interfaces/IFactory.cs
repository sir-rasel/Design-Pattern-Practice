using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern.Interfaces
{
    interface IFactory
    {
        public void AssembleProduct();
        public IGPU CreateGpu();
        public IMonitor CreateMonitor();
    }
}
