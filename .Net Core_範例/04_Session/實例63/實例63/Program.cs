using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 實例63
{
    class Program
    {
        static void Main(string[] args)
        {
            Sample(1, 2, 3, 4, 5);
            Sample(9, 8);
            Console.ReadKey();
        }

        static void Sample(params int[] numbers)
        {
            foreach(int i in numbers)
            {
                Console.WriteLine(i);
            }
        }
    }
}
