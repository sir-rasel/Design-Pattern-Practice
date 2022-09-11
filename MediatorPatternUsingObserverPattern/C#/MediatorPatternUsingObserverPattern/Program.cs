using MediatorPatternUsingObserverPattern.Classes;
using System;

namespace MediatorPatternUsingObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            DialogBox dialogBox = new DialogBox();
            dialogBox.SimulateUserInteraction();
        }
    }
}
