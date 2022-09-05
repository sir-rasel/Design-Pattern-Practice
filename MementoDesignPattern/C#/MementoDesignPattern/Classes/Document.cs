using System;
using System.Collections.Generic;
using System.Text;

namespace MementoDesignPattern
{
    class Document : IDocument
    {
        private string objective;

        private string GetObjective()
        {
            return objective;
        }

        private void SetObjective(string objective)
        {
            this.objective = objective;
        }

        private string content;

        private string GetContent()
        {
            return content;
        }

        private void SetContent(string content)
        {
            this.content = content;
        }

        string IDocument.GetObjective()
        {
            return this.GetObjective();
        }

        void IDocument.SetObjective(string objective)
        {
            this.SetObjective(objective);
        }

        string IDocument.GetContent()
        {
            return this.GetContent();
        }

        void IDocument.SetContent(string content)
        {
            this.SetContent(content);
        }

        public Document(string objective = null, string content = null)
        {
            this.objective = objective;
            this.content = content;
        }
    }
}
