using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 實例72
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string, int> d1 = TestA;
            d1("Bob", 28);
            Action<string> d2 = TestB;
            d2("Jim");

            Func<DateTime, int> d3 = TestC;
            Console.WriteLine($"今年是{d3(DateTime.Now)}年");
            Func<int, int, long> d4 = TestD;
            long a = d4(2, 4);
            Console.WriteLine($"計算結果：{a}");
            Console.ReadKey();
        }

        static void TestA(string name,int age)
        {
            Console.WriteLine($"{name}今年{age}歲了");
        }

        static void TestB(string name)
        {
            Console.WriteLine($"你好，{name}");
        }

        static int TestC(DateTime dt)
        {
            return dt.Year;
        }

        static long TestD(int start,int end)
        {
            long r = 1L;
            int cur = start;
            while(cur<=end)
            {
                r *= cur;
                cur++;
            }
            return r;
        }
    }
}
