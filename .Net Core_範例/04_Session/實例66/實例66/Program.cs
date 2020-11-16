using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 實例66
{
    class Program
    {
        static void Main(string[] args)
        {
            Something(20, 100, true);
            Something(31, 1);
            Something(p1: 65, p3: true);
            //Something(900, , true);
            Console.ReadKey();
        }

        static void Something(int p1, byte p2 = 255, bool p3 = false)
        {
            string msg = "參數列表\n" +
                $"{nameof(p1)}={p1}\n{nameof(p2)}={p2}\n{nameof(p3)}={p3}\n";
            Console.WriteLine(msg);
        }
    }
}
