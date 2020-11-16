using System;
using System.Collections.Generic;

namespace 實例184
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> set = new HashSet<int>();

            bool b = set.Add(1000);
            Console.WriteLine("元素{0}{1}。",1000,b?"增加成功": "未增加");


            b = set.Add(2000);
            Console.WriteLine("元素{0}{1}。", 2000, b ? "增加成功" : "未增加");


            b = set.Add(1000);
            Console.WriteLine("元素{0}{1}。", 1000, b ? "增加成功" : "未增加");
        }
    }
}
