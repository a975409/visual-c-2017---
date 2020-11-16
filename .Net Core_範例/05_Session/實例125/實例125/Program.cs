using System;

namespace 實例125
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = new DateTime(2018, 4, 1);
            DateTime d2 = d1.AddDays(6d);
            DateTime d3 = d1.AddDays(-3d);

            Console.WriteLine($"初始日期：{d1.ToString("yyyy/MM/dd")}");
            Console.WriteLine($"6天後：{d2.ToString("yyyy/MM/dd")}");
            Console.WriteLine($"3天前：{d3.ToString("yyyy/MM/dd")}");

            Console.ReadKey();
        }
    }
}
