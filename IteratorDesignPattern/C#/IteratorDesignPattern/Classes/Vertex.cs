using IteratorDesignPattern.Interfaces;
using System.Collections.Generic;

namespace IteratorDesignPattern.Classes
{
    class Vertex<T> : IIteratorCollection<T>
    {
        private T _data { get; set; }
        public T Data { get { return _data; } set { _data = value; } }
        public bool Visited { get; set; }

        private List<Vertex<T>> Neighbors { get; set; }

        public Vertex(T data)
        {
            Data = data;
            Neighbors = new List<Vertex<T>>();
        }
        public void SetNeighbors(List<Vertex<T>> neighbors)
        {
            Neighbors = neighbors;
        }

        public void SetVisited()
        {
            Visited = true;
        }

        public List<Vertex<T>> GetNeighbors()
        {
            return Neighbors;
        }

        public Iterator<T> GetDepthFirstIterator()
        {
            return new DepthFirstIterator<T>(this);
        }
    }
}
