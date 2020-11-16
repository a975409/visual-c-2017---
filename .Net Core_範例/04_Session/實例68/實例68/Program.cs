using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 實例68
{
    class Program
    {
        delegate double DoSomething(int x, double y);
        static void Main(string[] args)
        {
            DoSomething dele = new DoSomething(RunHere);
            double res = dele(16, 27.67d);
            Console.WriteLine(res);
            Console.ReadKey();
        }

        static double RunHere(int a,double b)
        {
            return a + b;
        }
    }
}
