using System;

namespace 實例159
{
    class Program
    {
        static void Main(string[] args)
        {
            Something1 v1 = new Something1();
            v1.Output(500, 99.88d);
            Something2<uint, ushort> v2 = new Something2<uint, ushort>();
            v2.Output(9009, 17);

            Something2<char, string> v3 = new Something2<char, string>();
            v3.Output('c', "cat");
        }
    }

    public interface ITest<P,Q>
    {
        void Output(P x, Q y);
    }

    public class Something1 : ITest<int, double>
    {
        public void Output(int x, double y)
        {
            Console.WriteLine("{0} - {1}", x.GetType(), x);
            Console.WriteLine("{0} - {1}\n", y.GetType(), y);
        }
    }

    public class Something2<J, K> : ITest<J, K>
    {
        public void Output(J x, K y)
        {
            Console.WriteLine("{0} - {1}", x.GetType(), x);
            Console.WriteLine("{0} - {1}\n", y.GetType(), y);
        }
    }
}
