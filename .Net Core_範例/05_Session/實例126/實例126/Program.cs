using System;

namespace 實例126
{
    class Program
    {
        static void Main(string[] args)
        {
            string ds = "2018年5月20日23:14:20";
            DateTime dt = DateTime.Parse(ds);

            Console.WriteLine(dt.Year);
            Console.WriteLine(dt.Month);
            Console.WriteLine(dt.Day);
            Console.ReadKey();
        }
    }
}
