using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 實例69
{
    class Program
    {
        delegate void MyFunction();

        static void Main(string[] args)
        {
            MyFunction del = null;
            del += Output1;
            del += Output2;

            del();
            Console.ReadKey();
        }

        static void Output1()
        {
            Console.WriteLine("這是第一個方法");
        }

        static void Output2()
        {
            Console.WriteLine("這是第二個方法");
        }
    }
}
