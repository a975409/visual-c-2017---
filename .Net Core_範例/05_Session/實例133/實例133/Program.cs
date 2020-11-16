using System;

namespace 實例133
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = "enlarge*a*picture";
            string[] results = test.Split('*');

            foreach(string s in results)
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();
            
        }
    }
}
