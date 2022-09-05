using System;
using System.Collections.Generic;
using System.Text;

namespace MementoDesignPattern
{
    interface IDocument
    {
        public string GetObjective();
        public void SetObjective(string objective);
        public string GetContent();
        public void SetContent(string content);
    }
}
