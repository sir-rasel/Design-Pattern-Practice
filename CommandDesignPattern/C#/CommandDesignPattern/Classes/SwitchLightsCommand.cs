using CommandDesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandDesignPattern.Classes
{
    class SwitchLightsCommand : ICommand
    {
        private Light Light { get; }
        public SwitchLightsCommand(Light light)
        {
            Light = light;
        }

        public void Execute()
        {
            Light.SwitchLights();
        }
    }
}
