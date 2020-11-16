using System;

namespace 實例205
{
    class Program
    {
        static void Main(string[] args)
        {
            (long BookID, string BookName, string Author) = (10000031L, "Sample Book", "Tommy");

            Console.WriteLine($"編號：{BookID}\n書名：{BookName}\n作者：{Author}");
        }
    }
}
