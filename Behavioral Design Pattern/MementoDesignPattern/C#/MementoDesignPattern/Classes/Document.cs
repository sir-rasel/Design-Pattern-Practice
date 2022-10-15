using System;
using System.Collections.Generic;
using System.Text;

namespace MementoDesignPattern
{
    class Document : IDocument
    {
        private string objective;
        private string content;

        public Document(string objective = null, string content = null)
        {
            this.objective = objective;
            this.content = content;
        }

        public Document(IDocument document)
        {
            objective = document.GetObjective();
            content = document.GetContent();
        }

        public string GetObjective()
        {
            return objective;
        }

        public void SetObjective(string objective)
        {
            this.objective = objective;
        }

        public string GetContent()
        {
            return content;
        }

        public void SetContent(string content)
        {
            this.content = content;
        }
    }
}
