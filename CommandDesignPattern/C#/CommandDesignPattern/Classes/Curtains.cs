using System;
using System.Collections.Generic;
using System.Text;

namespace CommandDesignPattern.Classes
{
    public class Curtains
    {
        private bool Open = false;

        public void OpenClose()
        {
            Open = !Open;
        }

        public bool IsOpen()
        {
            return Open;
        }
    }
}
