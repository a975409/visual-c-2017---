using System;
using System.Security.Cryptography;

namespace 實例142
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "abcd";
            string s2 = "ABCD";

            int rc = string.Compare(s1, s2, true);

            Console.WriteLine("{0}", rc == 0 ? "相等" : "不相等");
            Console.ReadKey();
        }
    }
}
