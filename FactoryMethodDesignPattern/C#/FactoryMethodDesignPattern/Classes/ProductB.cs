﻿using FactoryMethodDesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodDesignPattern.Classes
{
    class ProductB : IProduct
    {
        public void Ready()
        {
            Console.WriteLine("Ready Product B");
        }
    }
}
