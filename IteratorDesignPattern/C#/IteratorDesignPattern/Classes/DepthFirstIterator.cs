using IteratorDesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorDesignPattern.Classes
{
    class DepthFirstIterator<T> : Iterator<T>
    {
        private Vertex<T> StartVertex { get; set; }
        private Stack<Vertex<T>> Stack { get; set; }

        public DepthFirstIterator(Vertex<T> startVertex)
        {
            StartVertex = startVertex;
            Stack = new Stack<Vertex<T>>();
            Stack.Push(startVertex);
        }

        public bool HasNext()
        {
            return (Stack.Count > 0);
        }

        public Vertex<T> GetNext()
        {
            if (!HasNext())
            {
                return null;
            }
            Vertex<T> current = Stack.Pop();
            if (!current.Visited)
            {
                current.SetVisited();
                Console.WriteLine(current.Data);
                current.GetNeighbors().ForEach(x => Stack.Push(x));
                return current;
            }
            return GetNext();
        }

        public void Reset()
        {
            Stack.Clear();
            Stack.Push(StartVertex);
        }
    }
}
