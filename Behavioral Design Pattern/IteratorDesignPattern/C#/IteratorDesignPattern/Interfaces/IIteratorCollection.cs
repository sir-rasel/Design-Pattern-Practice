using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorDesignPattern.Interfaces
{
    interface IIteratorCollection<T>
    {
        Iterator<T> GetDepthFirstIterator();
    }
}
