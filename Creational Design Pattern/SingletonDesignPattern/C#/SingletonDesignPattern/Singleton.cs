using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonDesignPattern
{
    sealed class Singleton
    {
        private static readonly Singleton instance = new Singleton();
        public static int NumberOfInstance { get; set; }

        private Singleton()
        {
            NumberOfInstance++;
        }

        public static Singleton Instance { get { return instance; } }
    }
}
