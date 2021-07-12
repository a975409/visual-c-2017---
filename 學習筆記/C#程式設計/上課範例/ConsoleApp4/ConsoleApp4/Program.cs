using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            //條件判斷式
            int x = 420;
            int y = 620;

            if (x > y)
            {   //true

                Console.WriteLine("x 大於 y");
            } else
            {   //false

                Console.WriteLine("x 小於或等於 y");
            }


            Console.ReadKey();
        }
    }
}
