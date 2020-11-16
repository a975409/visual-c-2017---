using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 實例71
{
    public delegate void DemoEventDelegate(int count);

    class Program
    {
        static void Main(string[] args)
        {
            Test t = new Test();
            //Lambda運算式
            //t.Worked += (k, f) => Console.WriteLine($"你已呼叫{f}次實例");

            t.Worked += delegate (int f)
            {
                Console.WriteLine($"你已呼叫{f}次實例");
            };

            t.Run();
            t.Run();
            t.Run();
            t.Run();
        }
    }

    class Test
    {
        DemoEventDelegate _myevent;
        private int c = 0;

        public event DemoEventDelegate Worked
        {
            add
            {
                if (value != null)
                    _myevent += value;
            }

            remove
            {
                _myevent -= value;
            }
        }

        public void Run()
        {
            _myevent.Invoke(++c);
        }
    }
}
