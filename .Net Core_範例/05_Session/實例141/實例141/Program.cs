using System;

namespace 實例141
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = "明日複明日，明日何其多";
            
            int first = test.IndexOf("明日");
            int last = test.LastIndexOf("明日");

            Console.WriteLine("第一次出現{0}的位置：{1}", test, first);
            Console.WriteLine("最後一次出現{0}的位置：{1}", test, last);

            Console.ReadKey();
        }
    }
}
