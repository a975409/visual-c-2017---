using System;

namespace 實例130
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = "I will be very hard to do it";
            Console.WriteLine($"全部轉為大寫："+test.ToUpper());
            Console.WriteLine($"全部轉為小寫：" + test.ToLower());
            Console.ReadKey();
        }
    }
}
