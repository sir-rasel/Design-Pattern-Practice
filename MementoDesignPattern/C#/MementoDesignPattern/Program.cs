using System;

namespace MementoDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IDocumentOriginator documentOriginator = new DocumentOriginator();
            IMementoCaretaker historyTracker = new MementoCaretaker(documentOriginator);

            documentOriginator.SetContent("content1");
            documentOriginator.SetObjective("objective1");
            historyTracker.Save();
            Console.WriteLine(documentOriginator.GetContent());
            Console.WriteLine(documentOriginator.GetObjective());

            documentOriginator.SetContent("content2");
            documentOriginator.SetObjective("objective2");
            historyTracker.Save();
            Console.WriteLine(documentOriginator.GetContent());
            Console.WriteLine(documentOriginator.GetObjective());

            documentOriginator.SetContent("content1");
            documentOriginator.SetObjective("objective1");
            Console.WriteLine(documentOriginator.GetContent());
            Console.WriteLine(documentOriginator.GetObjective());

            historyTracker.Undo();
            Console.WriteLine(documentOriginator.GetContent());
            Console.WriteLine(documentOriginator.GetObjective());

            historyTracker.Undo();
            Console.WriteLine(documentOriginator.GetContent());
            Console.WriteLine(documentOriginator.GetObjective());

            historyTracker.Undo();
            Console.WriteLine(documentOriginator.GetContent());
            Console.WriteLine(documentOriginator.GetObjective());

            historyTracker.Redo();
            Console.WriteLine(documentOriginator.GetContent());
            Console.WriteLine(documentOriginator.GetObjective());

            historyTracker.Redo();
            Console.WriteLine(documentOriginator.GetContent());
            Console.WriteLine(documentOriginator.GetObjective());
        }
    }
}
