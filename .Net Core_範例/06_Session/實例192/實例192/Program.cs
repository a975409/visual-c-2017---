using System;
using System.Collections.Generic;

namespace 實例192
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<int, string> dic = new SortedDictionary<int, string>();

            dic[20] = "hook";
            dic[5] = "book";
            dic[32] = "look";
            dic[3] = "disk";
            dic[12] = "list";
            dic[7] = "foot";

            foreach (var a in dic)
                Console.WriteLine($"{a.Key} - {a.Value}");
        }
    }
}
