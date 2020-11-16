using System;

namespace 實例153
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "1011101001";
            int result = Convert.ToInt32(str, 2);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
