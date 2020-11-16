using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 實例86
{
    class Program
    {
        static void Main(string[] args)
        {
            TheOut theOut = new TheOut();
            TheOut.TheNest nest = new TheOut.TheNest();

            theOut.NestObj = nest;
            theOut.CallNest();
            Console.ReadKey();

        }
    }

    class TheOut
    { 
        public TheNest NestObj { get; set; }

        public void CallNest()
        {
            NestObj?.CallMe();
        }

        public class TheNest
        {
            public void CallMe() => Console.WriteLine("正在存取巢狀結構的類別實例");
        }
    }
}
