using System;
using System.Collections.Generic;
using System.Text;

namespace MementoDesignPattern
{
    class DocumentOrganizer
    {
        private IDocument Document;

        public DocumentOrganizer(IDocument document = null)
        {
            this.Document = document;
        }
    }
}
