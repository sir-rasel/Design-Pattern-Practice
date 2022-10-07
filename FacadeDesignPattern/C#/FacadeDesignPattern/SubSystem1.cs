using System;
using System.Collections.Generic;
using System.Text;

namespace FacadeDesignPattern
{
    public class SubSystem1
    {
        public string Operation1()
        {
            return "Subsystem1: Ready!\n";
        }

        public string OperationN()
        {
            return "Subsystem1: Go!\n";
        }
    }
}
