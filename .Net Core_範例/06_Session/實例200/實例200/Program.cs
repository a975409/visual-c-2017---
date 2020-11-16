using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;

namespace 實例200
{
    class Program
    {
        static void Main(string[] args)
        {
            using (BlockingCollection<int> bc = new BlockingCollection<int>())
            {
                Task t1 = Task.Run(async () =>
                  {
                      for (int k = 0; k < 5; k++)
                      {
                          int item = k + 1;
                          Console.WriteLine("即將增加元素：{0}", item);
                          bc.Add(item);
                          await Task.Delay(650);
                      }

                      bc.CompleteAdding();
                  });

                Task t2 = Task.Run(() =>
                  {
                      while (true)
                      {
                          if (bc.TryTake(out int item))
                          {
                              Console.WriteLine("取出元素：{0}", item);
                          }

                          if (bc.IsCompleted)
                              break;
                      }
                  });

                Task.WaitAll(t1, t2);
                t1.Dispose();
                t2.Dispose();
            }
        }
    }
}
