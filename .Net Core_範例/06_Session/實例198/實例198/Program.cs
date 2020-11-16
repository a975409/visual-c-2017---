using System;
using System.Diagnostics;

namespace 實例198
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "我家裡養了20隻貓";

            Stopwatch sw1 = Stopwatch.StartNew();

            for(int x=0;x<10000000;x++)
            {
                int v = int.Parse(str.Substring(5, 2));
            }

            sw1.Stop();
            Console.WriteLine($"正常方法：耗時{sw1.ElapsedMilliseconds} ms");

            Stopwatch sw2 = Stopwatch.StartNew();

            ReadOnlySpan<char> span = str.ToCharArray();

            for (int x = 0; x < 10000000; x++)
            {
                int v = 0;
                var subspan = span.Slice(5, 2);

                for (int i = 0; i < subspan.Length; i++)
                {
                    char ch = subspan[i];
                    v = (ch - '0') + v * 10;
                }
            }

            sw2.Stop();

            Console.WriteLine($"使用：耗時{sw2.ElapsedMilliseconds} ms");
        }
    }
}
