using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPatternUsingObserverPattern.Classes
{
    class CheckBox : UIControl
    {
        private string CheckedItem { get; set; }

        public string GetCheckedItem()
        {
            return CheckedItem;
        } 
        public void CheckItem(string item)
        {
            CheckedItem = item;
            NotifyEventHandlers();
        }
    }
}
