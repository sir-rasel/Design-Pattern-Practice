using System;
using System.Collections.Generic;
using System.Text;

namespace MementoDesignPattern
{
    class MementoCaretaker : IMementoCaretaker
    {
        private Stack<IDocumentMemento> UndoStack;
        private Stack<IDocumentMemento> RedoStack;

        private readonly IDocumentOriginator documentOriginator;

        public MementoCaretaker(IDocumentOriginator documentOriginator)
        {
            this.documentOriginator = documentOriginator;
            UndoStack = new Stack<IDocumentMemento>();
            RedoStack = new Stack<IDocumentMemento>();
        }

        public void Redo()
        {
            if (RedoStack.Count == 0)
            {
                return;
            }

            IDocumentMemento backupData = RedoStack.Pop();
            UndoStack.Push(backupData);
            documentOriginator.Restore(backupData);
        }

        public void Save()
        {
            UndoStack.Push(documentOriginator.Save());
        }

        public void Undo()
        {
            if(UndoStack.Count == 0)
            {
                return;
            }

            IDocumentMemento backupData = UndoStack.Pop();
            RedoStack.Push(backupData);
            documentOriginator.Restore(backupData); 
        }

        public void ClearHistory()
        {
            UndoStack.Clear();
            RedoStack.Clear();
        }
    }
}
