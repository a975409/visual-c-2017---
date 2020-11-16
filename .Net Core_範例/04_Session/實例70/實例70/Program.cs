using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace 實例70
{
    class Program
    {
        delegate void Test(double a, double b);

        static void Main(string[] args)
        {
            Test td = null;
            td += delegate (double a, double b)
            {
                Console.WriteLine($"{a}+{b}={a + b}");
            };

            td += delegate (double a, double b)
            {
                Console.WriteLine($"{a}-{b}={a - b}");
            };

            td += delegate (double a, double b)
            {
                Console.WriteLine($"{a}X{b}={a * b}");
            };

            td(0.3d, 0.2d);
            Console.ReadKey();
        }
    }
}
