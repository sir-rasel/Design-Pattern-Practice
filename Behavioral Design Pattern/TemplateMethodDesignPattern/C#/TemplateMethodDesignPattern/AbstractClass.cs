using System;

namespace TemplateMethodDesignPattern
{
    abstract class AbstractClass
    {
        public void TemplateMethod()
        {
            BaseOperation1();
            RequiredOperations1();
            BaseOperation2();
            Hook1();

            RequiredOperation2();
            BaseOperation3();
            Hook2();
        }

        protected void BaseOperation1()
        {
            Console.WriteLine("AbstractClass says: I am doing the bulk of the work");
        }

        protected void BaseOperation2()
        {
            Console.WriteLine("AbstractClass says: But I let subclasses override some operations");
        }

        protected void BaseOperation3()
        {
            Console.WriteLine("AbstractClass says: But I am doing the bulk of the work anyway");
        }

        protected abstract void RequiredOperations1();

        protected abstract void RequiredOperation2();

        protected virtual void Hook1() { }

        protected virtual void Hook2() { }
    }
}
