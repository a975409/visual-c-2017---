using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 實例62
{
    class Program
    {
        static void Main(string[] args)
        {
            double r;
            Work(2.001d, 0.855d, out r);

            Console.WriteLine("計算結果：" + r);
            Console.ReadKey();
        }

        static void Work(double x,double y,out double result)
        {
            result = x + y;
        }
    }
}
