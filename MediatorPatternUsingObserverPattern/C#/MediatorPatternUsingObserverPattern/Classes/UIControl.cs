using MediatorPatternUsingObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPatternUsingObserverPattern.Classes
{
    abstract class UIControl : ISubject
    {
        public IList<HandleEvent> EventHandlers { get; set; }

        protected UIControl()
        {
            EventHandlers = new List<HandleEvent>();
        }


        public void Attach(HandleEvent eventHandler)
        {
            EventHandlers.Add(eventHandler);
        }

        public void NotifyEventHandlers()
        {
            foreach (var eventHandler in EventHandlers)
                eventHandler();
        }
    }
}
