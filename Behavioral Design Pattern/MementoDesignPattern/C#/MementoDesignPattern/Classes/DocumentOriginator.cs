using System;
using System.Collections.Generic;
using System.Text;

namespace MementoDesignPattern
{
    class DocumentOriginator : IDocumentOriginator
    {
        private IDocument Document;
        public DocumentOriginator()
        {
            Document = new Document();
        }

        public IDocumentMemento Save()
        {
            IDocumentMemento document = new DocumentMememto(Document);
            return document;
        }

        public void Restore(IDocumentMemento memento)
        {
            Document = memento.GetDocument();
        }

        public void SetContent(string content)
        {
            Document.SetContent(content);
        }

        public string GetContent()
        {
            return Document.GetContent();
        }

        public void SetObjective(string objective)
        {
            Document.SetObjective(objective);
        }
        public string GetObjective()
        {
            return Document.GetObjective();
        }
    }
}
