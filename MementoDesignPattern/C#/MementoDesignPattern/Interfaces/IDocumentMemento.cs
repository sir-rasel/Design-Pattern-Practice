using System;
using System.Collections.Generic;
using System.Text;

namespace MementoDesignPattern
{
    interface IDocumentMemento
    {
        public IDocument GetDocument();
        public DateTime GetDocumentSavingDateTime();
    }
}
