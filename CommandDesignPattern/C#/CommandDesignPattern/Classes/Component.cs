using CommandDesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandDesignPattern.Classes
{
    public abstract class Component
    {
        private ICommand Command;

        public void SetCommand(ICommand command)
        {
            Command = command;
        }

        public void ExecuteCommand()
        {
            Command.Execute();
        }
    }
}
