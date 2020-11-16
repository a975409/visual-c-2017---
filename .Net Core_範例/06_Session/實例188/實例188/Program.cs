using System;
using System.Collections.Generic;

namespace 實例188
{
    class Program
    {
        
        
        static void Main(string[] args)
        {
            IDictionary<string, double> dic = new Dictionary<string, double>();

            dic["a"] = 0.0001d;
            dic["b"] = 0.0002d;
            dic["c"] = 0.0003d;

            Console.WriteLine("鍵 \"a\" {0}", dic.ContainsKey("a") ? "存在" : "不存在");
            Console.WriteLine("鍵 \"d\" {0}", dic.ContainsKey("d") ? "存在" : "不存在");


        }
    }
}
