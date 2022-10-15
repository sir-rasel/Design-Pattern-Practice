using System;

namespace CompositeDesignPattern.Classes
{
    class Client
    {
        public void CallingLeafOperation(Component leaf)
        {
            Console.WriteLine($"RESULT: {leaf.Operation()}\n");
        }

        public void CallingComplexTreeOperation(Component composite, Component leaf)
        {
            if (composite.IsComposite())
            {
                composite.Add(leaf);
            }

            Console.WriteLine($"RESULT: {composite.Operation()}");
        }
    }
}
