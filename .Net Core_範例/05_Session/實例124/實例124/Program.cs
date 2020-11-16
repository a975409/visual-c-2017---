using System;

namespace 實例124
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan s = new TimeSpan(24, 0, 0);
            string str = $"一天內總共有{s.TotalSeconds}秒";
            Console.WriteLine(str);
            s = new TimeSpan(3, 0, 0, 0);
            str = $"三天內總共有{s.TotalSeconds}秒";
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
