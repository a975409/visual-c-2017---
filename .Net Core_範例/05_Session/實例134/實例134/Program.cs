using System;

namespace 實例134
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "明天去買一台洗衣機";
            string res = str.Replace("洗衣機", "電冰箱");
            Console.WriteLine($"原字串：{str}\n取代後字串：{res}");
            Console.ReadKey();

            
        }
    }
}
