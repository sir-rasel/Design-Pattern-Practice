using System;
using System.Collections.Generic;
using System.Text;

namespace CommandDesignPattern.Classes
{
    class FloorLamp : Component
    {
        private readonly Light Light;

        public FloorLamp()
        {
            Light = new Light();
        }

        public Light GetLight()
        {
            return Light;
        }

        public bool IsLightOn()
        {
            return Light.IsSwitchedOn();
        }
    }
}
