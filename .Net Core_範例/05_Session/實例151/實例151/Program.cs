using System;

namespace 實例151
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2018, 2, 1, 16, 37, 11);
            Console.WriteLine($"自訂日期/時間格式：{dt.ToString("yyyy-M-d，HH:mm:ss")}");

            Console.ReadKey();
        }
    }
}
