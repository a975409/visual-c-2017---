using System;

namespace 實例148
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal d = 8582113.76352M;

            Console.WriteLine("{0,-15}{1,-20:G}", "G", d);
            Console.WriteLine("{0,-15}{1,-20:N}", "N", d);

            Console.ReadKey();
        }
    }
}
