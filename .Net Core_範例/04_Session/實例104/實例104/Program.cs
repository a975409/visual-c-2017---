using System;

namespace 實例104
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            A a = new A();
            a?.Work();

            A p = null;
            p?.Work();

            Console.ReadKey();
        }
    }

    class A
    {
        public void Work() => Console.WriteLine("{0} 方法被呼叫。", nameof(Work));
    }

}
