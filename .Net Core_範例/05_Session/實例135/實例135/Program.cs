using System;

namespace 實例135
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "abcdefg";
            string result = ReverseString(str);

            Console.WriteLine(result);

            Console.ReadKey();
        }

        static string ReverseString(string str)
        {
            char[] ch = str.ToCharArray();
            Array.Reverse(ch);
            return new string(ch);
        }
    }
}
