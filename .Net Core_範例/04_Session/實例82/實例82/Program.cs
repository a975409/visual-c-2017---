using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace 實例82
{
    class Program
    {
        static void Main(string[] args)
        {
            Test();
            GC.Collect();
            ReadKey();
        }

        static void Test()
        {
            Example ex = new Example();
            
        }
    }

    class Example
    {
        public Example()
        {
            WriteLine("建置函數被呼叫");
        }

        ~Example()
        {
            WriteLine("解構函數被呼叫");
        }
    }
}
