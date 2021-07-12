using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //算術運算子
            int x = 9;
            int y = 4;
            int z;

            z = x + y;
            z = x - y;
            z = x * y;
            z = x / y;
            z = x % y;
            z = -y;
            z = x + y * y;
            z = (x - y) / y;

            Console.WriteLine("z的值為:" + z);
            Console.WriteLine("----------------------------");


            //指定運算子
            int d = 250;
            int f = 50;

            d += 250; // d = d + 250;
            d -= f;
            d *= 2;
            d /= 5;
            d %= 7;

            Console.WriteLine("d的值:" + d);
            Console.WriteLine("----------------------------");

            //遞增,遞減運算子
            int r = 8;
            int s = 6;
            r++;
            s--;
            Console.WriteLine("r:{0} , s:{1}", r, s);
            Console.WriteLine("----------------------------");

            //關係運算式
            double m = 85.22;
            double n = 45.64;
            bool compare = false;

            compare = m == n;
            compare = m != n;
            compare = m >= n;
            compare = m <= n;
            compare = m > n;
            compare = m < n;

            Console.WriteLine("m,n比較結果:" + compare);
            Console.WriteLine("----------------------------");

            //多種複合條件關係
            float p = 56.78f;
            float w = 92.31f;
            bool logic = false;

            logic = (p < w) && (p >= 50.0f); //true
            logic = (p > 60.0f) && (p != w); //false
            logic = (w <= 80.0f) || (p <= w); //true
            logic = (p > w) || (w < 20.0f); //false
            logic = ((p > 40.0f) && (w < 120.0f)) && (p >= w); //false
            logic = (p > 10.0f) || (w > 75.0f) || (p >= w); //true

            Console.WriteLine("比較結果:" + logic);
            Console.WriteLine("----------------------------");
            Console.ReadKey();

        }
    }
}
