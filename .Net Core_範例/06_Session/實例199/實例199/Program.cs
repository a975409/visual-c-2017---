using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;

namespace 實例199
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcurrentBag<int> bag = new ConcurrentBag<int>();
            Task t1 = Task.Run(() =>
            {
                for (int k = 45; k < 51; k++)
                {
                    Console.WriteLine("即將增加元素：{0}", k);
                    bag.Add(k);
                }
            });

            Task t2=t1.ContinueWith((task)=>
            {
                while (!bag.IsEmpty)
                {
                    if (bag.TryTake(out int result))
                    {
                        Console.WriteLine("已取出元素：{0}", result);
                    }
                }
            });
            Task.WaitAll(t1, t2);
        }
    }
}
