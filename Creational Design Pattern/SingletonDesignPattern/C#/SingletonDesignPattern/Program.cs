using System;

namespace SingletonDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton SingletonObject1 = Singleton.Instance;
            Console.WriteLine(Singleton.NumberOfInstance);

            // This new object create call of singleton class give error
            // Singleton obj = new Singleton();

            Singleton SingletonObject2 = Singleton.Instance;
            Console.WriteLine(Singleton.NumberOfInstance);
        }
    }
}
