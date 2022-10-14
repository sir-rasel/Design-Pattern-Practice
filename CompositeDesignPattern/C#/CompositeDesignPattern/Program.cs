using CompositeDesignPattern.Classes;
using System;

namespace CompositeDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();

            Leaf leaf = new Leaf();
            Console.WriteLine("Client: I get a simple component:");
            client.CallingLeafOperation(leaf);

            CompositeComponent tree = new CompositeComponent();

            CompositeComponent branch1 = new CompositeComponent();
            branch1.Add(new Leaf());
            branch1.Add(new Leaf());

            CompositeComponent branch2 = new CompositeComponent();
            branch2.Add(new Leaf());
            tree.Add(branch1);
            tree.Add(branch2);

            Console.WriteLine("Client: Now I've got a composite tree:");
            client.CallingLeafOperation(tree);

            Console.WriteLine("Client: I don't need to check the components classes even when managing the tree:");
            client.CallingComplexTreeOperation(tree, leaf);
        }
    }
}