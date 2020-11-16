using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 實例76
{
    class Program
    {
        static void Main(string[] args)
        {
            MyTest t = new MyTest();
            t.Output();
            Console.ReadKey();
        }
    }

    class MyBase
    {
        public virtual void Output()
        {
            Console.WriteLine("基礎類別的方法呼叫");
        }
    }

    class MyTest : MyBase
    {
        public override void Output()
        {
            Console.WriteLine("衍伸類別的方法呼叫");
            //base.Output();
        }
    }

}
