using System;

namespace 實例112
{
    class Program
    {
        static void Main(string[] args)
        {
            int? x = null;

            if (x.HasValue)
                Console.WriteLine("變數x的值為：{0}。", x);
            else
                Console.WriteLine("變數x的值為null");

            double? y = 91.3d;

            if (y.HasValue)
                Console.WriteLine("變數y的值為：{0}。", y);
            else
                Console.WriteLine("變數y的值為null");

            Console.ReadKey();
        }
    }
}
