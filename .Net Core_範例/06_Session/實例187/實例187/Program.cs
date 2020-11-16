using System;
using System.Collections.Generic;

namespace 實例187
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(25);
            list.Add(26);
            list.Add(27);
            Console.WriteLine("清單中位元個數：{0}",list.Count);
            list.Clear();
            Console.WriteLine("呼叫Clear後，清單中位元個數：{0}", list.Count);
        }
    }
}
