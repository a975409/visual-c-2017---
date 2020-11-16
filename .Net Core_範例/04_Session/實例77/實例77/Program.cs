using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 實例77
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckTask t1 = new CheckTask();
            t1.Run(15);

            DRCheckTask t2 = new DRCheckTask();
            t2.Run(10);

            Console.ReadKey();
        }
    }

    class CheckTask
    { 
        public void Run(int max)
        {
            Console.WriteLine("最大執行工作數：{0}。", max);
        }
    }

    class DRCheckTask : CheckTask
    {
        public new void Run(int count)
        {
            Console.WriteLine("平行工作數：{0}。", count);
        }
    }
}
