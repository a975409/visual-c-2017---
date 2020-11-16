using System;
using System.Net;

namespace 實例156
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "<1>Item 1\n<2>Item 2\n<3>Item 3 & Item 4";
            string htmlstr = WebUtility.HtmlEncode(str);

            Console.WriteLine($"原字串：\n{str}\n");
            Console.WriteLine($"HTML 編碼後的字串：\n{htmlstr}");

            Console.ReadKey();
        }
    }
}
