using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 實例88
{
    class Program
    {
        static void Main(string[] args)
        {
            Options a = Options.OneWay;
            Options b = Options.TwoWay;
            Options c = Options.MixWay;

            Console.WriteLine($"常數名：{a},常數值：{(int)a}");
            Console.WriteLine($"常數名：{b},常數值：{(int)b}");
            Console.WriteLine($"常數名：{c},常數值：{(int)c}");
            Console.ReadKey();
        }
    }

    enum Options
    {
        OneWay = 1,
        TwoWay = 2,
        MixWay = 3,
    }
}
