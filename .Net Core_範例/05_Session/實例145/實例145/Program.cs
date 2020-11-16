using System;

namespace 實例145
{
    class Program
    {
        static void Main(string[] args)
        {
            float val = 0.1785f;

            Console.WriteLine($"{"p",-15}{val,-10:p}");
            Console.WriteLine($"{"p3",-15}{val,-10:p3}");

            Console.ReadKey();
        }
    }
}
