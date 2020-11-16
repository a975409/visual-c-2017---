using System;

namespace 實例127
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "abc";
            string s2 = "def";
            string s3 = "ghi";

            string sn = string.Concat(s1, s2, s3);

            Console.WriteLine(sn);
            Console.ReadKey();
        }
    }
}
