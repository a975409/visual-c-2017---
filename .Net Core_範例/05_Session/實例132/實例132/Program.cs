using System;

namespace 實例132
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] test = { "day", "toy", "try", "pay", "they", "may" };

            foreach(string s in test)
            {
                if(s.EndsWith("ay"))
                    Console.WriteLine(s);
            }

            Console.ReadKey();
        }
    }
}
