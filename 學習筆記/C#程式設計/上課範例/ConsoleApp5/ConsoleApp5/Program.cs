using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Loop 迴圈
            for (int i = 1; i <= 10; i += 1)
            {
                Console.WriteLine("i 的值是 " + i);
            }
            Console.WriteLine("------------------------");
            for (int i = 2; i <= 20; i += 2)
            {
                //2,4,6,8,10,12,14,16,18,20
                Console.WriteLine("i 的值是 " + i);
            }
            Console.WriteLine("------------------------");
            for (int i = 10; i >= 1; i -= 1)
            {
                if (i == 5)
                {
                    //break; //中斷loop
                    continue; //跳過此次迴圈執行
                }
                Console.WriteLine("i 的值是 " + i);
            }
            Console.WriteLine("------------------------");
            for (int i = 1; i < 10; i += 1)
            {
                for (int j = 1; j < 10; j += 1)
                {
                    Console.WriteLine(i + "x" + j + "=" + i * j + ", ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("------------------------");
            int d = 1;
            while (d <= 10)
            {
                Console.WriteLine("d的值:" + d);
                d += 1;
            }
            Console.WriteLine("------------------------");
            int e = 1;
            do
            {
                Console.WriteLine("e的值:" + e);
                e += 2;
            }
            while (e <= 20);




            Console.ReadKey();

        }
    }
}
