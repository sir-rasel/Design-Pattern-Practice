using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPatternUsingObserverPattern.Classes
{
    class TextArea : UIControl
    {
        private string Content { get; set; }

        public string GetContent()
        {
            return Content;
        }

        public void SetContent(string content)
        {
            Content = content;
            NotifyEventHandlers();
        }
    }
}
