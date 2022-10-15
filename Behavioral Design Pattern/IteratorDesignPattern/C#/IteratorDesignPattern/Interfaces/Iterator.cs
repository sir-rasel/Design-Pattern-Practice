using IteratorDesignPattern.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorDesignPattern.Interfaces
{
    interface Iterator<T>
    {
        bool HasNext();

        Vertex<T> GetNext();

        void Reset();
    }
}
