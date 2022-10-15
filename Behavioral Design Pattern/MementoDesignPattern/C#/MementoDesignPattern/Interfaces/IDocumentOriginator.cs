using System;
using System.Collections.Generic;
using System.Text;

namespace MementoDesignPattern
{
    interface IDocumentOriginator : IDocument
    {
        public IDocumentMemento Save();
        public void Restore(IDocumentMemento memento);
    }
}
