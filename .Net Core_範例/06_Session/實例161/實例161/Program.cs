using System;

namespace 實例161
{
    class Program
    {
        static void Main(string[] args)
        {
            Sample s = new Sample();
            s.DoSomething('z');
            s.DoSomething((byte)5);

            A xa = s.GetSomething<A>();
            B xb = s.GetSomething<B>();
        }
    }

    public class A
    { }

    public class B
    { }

    class Sample
    {
        public void DoSomething<T>(T p) where T : struct
        {
            Console.WriteLine("{0} - {1}", p.GetType().Name, p);
        }

        public T GetSomething<T>() where T : class, new()
        {
            return new T();
        }
            
    }
}
