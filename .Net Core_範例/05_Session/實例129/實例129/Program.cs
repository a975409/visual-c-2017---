using System;

namespace 實例129
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = "I need peace with you";
            bool b = test.Contains("need");

            Console.WriteLine("句子{0}中{1}單字need。", test, b ? "包含" : "不包含");
            Console.ReadKey();
        }
    }
}
