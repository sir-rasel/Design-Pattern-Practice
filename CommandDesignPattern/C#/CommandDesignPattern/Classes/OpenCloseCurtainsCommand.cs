using CommandDesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandDesignPattern.Classes
{
    class OpenCloseCurtainsCommand : ICommand
    {
        private Curtains Curtains { get; }
        public OpenCloseCurtainsCommand(Curtains curtains)
        {
            Curtains = curtains;
        }

        public void Execute()
        {
            Curtains.OpenClose();
        }
    }
}
