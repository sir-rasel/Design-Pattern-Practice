using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPatternUsingObserverPattern.Classes
{
    class Button : UIControl
    {
        private bool IsEnabled { get; set; }
        public bool CheckIsEnabled()
        {
            return IsEnabled;
        }

        public void SetEnabled(bool enabled)
        {
            IsEnabled = enabled;
            NotifyEventHandlers();
        }
    }
}
