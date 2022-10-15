using System;
using System.Collections.Generic;
using System.Text;

namespace CommandDesignPattern.Classes
{
    class Light
    {
        private bool SwitchedOn = false;

        public void SwitchLights()
        {
            SwitchedOn = !SwitchedOn;
        }

        public bool IsSwitchedOn()
        {
            return SwitchedOn;
        }
    }
}
