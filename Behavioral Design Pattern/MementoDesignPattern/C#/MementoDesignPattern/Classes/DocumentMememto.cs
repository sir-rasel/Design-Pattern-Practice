using System;
using System.Collections.Generic;
using System.Text;

namespace MementoDesignPattern
{
    class DocumentMememto : IDocumentMemento
    {
        private IDocument Document;
        private DateTime SavingDateTime;

        public DocumentMememto(IDocument document = null)
        {
            Document = new Document(document);
            SavingDateTime = DateTime.Now;
        }

        public IDocument GetDocument()
        {
            return Document;
        }

        public DateTime GetDocumentSavingDateTime()
        {
            return SavingDateTime;
        }
    }
}
