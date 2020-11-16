using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 實例59
{
    class Program
    {
        static void Main(string[] args)
        {
            SomeType s = new SomeType("000-862-2-1515");

            Console.WriteLine(s.GenericKey);
            Console.ReadKey();
        }
    }
}
