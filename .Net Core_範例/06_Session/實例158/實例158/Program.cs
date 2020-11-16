using System;

namespace 實例158
{
    class Program
    {
        static void Main(string[] args)
        {
            Sample<string> s1 = new Sample<string>();
            s1.Work("Hello");

            Sample<DateTime> s2 = new Sample<DateTime>();
            s2.Work(DateTime.Now);
        }
    }

    public class Sample<K>
    {
        public void Work(K p)
        {
            Console.WriteLine($"{p.GetType().FullName,-20}:{p}");
        }
    }
}
