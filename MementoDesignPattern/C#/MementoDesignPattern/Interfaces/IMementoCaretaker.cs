using System;
using System.Collections.Generic;
using System.Text;

namespace MementoDesignPattern
{
    interface IMementoCaretaker
    {
        public void Undo();
        public void Redo();
        public void Save();
        public void ClearHistory();
    }
}
