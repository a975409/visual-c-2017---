using System;

namespace 實例150
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2018, 5, 1);

            Console.WriteLine($"長日期：{dt:D}");
            Console.WriteLine($"短日期：{dt:d}");

            Console.ReadKey();
        }
    }
}
