using System;
using System.Collections.Generic;
using System.Text;

namespace CommandDesignPattern.Classes
{
    public class Room : Component
    {
        private readonly Curtains Curtains;

        public Room()
        {
            Curtains = new Curtains();
        }

        public Curtains GetCurtains()
        {
            return Curtains;
        }

        public bool CurtainsOpen()
        {
            return Curtains.IsOpen();
        }
    }
}
