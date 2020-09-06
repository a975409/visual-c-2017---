using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_to_1_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            for (int i = 11; i >= 1; i -= 2)
            {
                num += i;
            }
            Console.WriteLine(num);

            double a = 0;
            for (double i = 0.5; i <= 10; i += 0.5)
            {
                a += i;
            }
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
