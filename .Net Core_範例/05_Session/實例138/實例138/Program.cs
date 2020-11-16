using System;

namespace 實例138
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] charr = { '3', 'f', '#', 'a' };

            foreach(char c in charr)
            {
                Console.WriteLine("{0} {1}", c, char.IsNumber(c) ? "是數字" : "不是數字");
            }

            Console.ReadKey();
        }
    }
}
