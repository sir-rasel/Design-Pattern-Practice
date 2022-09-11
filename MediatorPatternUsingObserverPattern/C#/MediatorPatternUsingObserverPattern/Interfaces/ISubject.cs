using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPatternUsingObserverPattern.Interfaces
{
    interface ISubject
    {
        void Attach(HandleEvent eventHandler);
        void NotifyEventHandlers();
    }
}
