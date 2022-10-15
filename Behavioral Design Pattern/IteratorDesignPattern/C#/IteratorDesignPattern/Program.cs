using IteratorDesignPattern.Classes;
using IteratorDesignPattern.Interfaces;
using System;
using System.Collections.Generic;

namespace IteratorDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Vertex<int> v0 = new Vertex<int>(0);
            Vertex<int> v1 = new Vertex<int>(1);
            Vertex<int> v2 = new Vertex<int>(2);
            Vertex<int> v3 = new Vertex<int>(3);
            Vertex<int> v4 = new Vertex<int>(4);
            Vertex<int> v5 = new Vertex<int>(5);
            Vertex<int> v6 = new Vertex<int>(6);

            v0.SetNeighbors(new List<Vertex<int>>() { v1, v5, v6 });
            v1.SetNeighbors(new List<Vertex<int>>() { v3, v4, v5 });
            v4.SetNeighbors(new List<Vertex<int>>() {v2, v6});
            v6.SetNeighbors(new List<Vertex<int>>() { v0 });

            Iterator<int> dfs = v0.GetDepthFirstIterator();
            while (dfs.HasNext())
            {
                dfs.GetNext();
            }
        }
    }
}
