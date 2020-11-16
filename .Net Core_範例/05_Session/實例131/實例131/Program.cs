using System;

namespace 實例131
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strs = { "abc", "opq", "uvw", "xyz" };
            string outstr = string.Join('_', strs);

            Console.WriteLine(outstr);
            Console.ReadKey();
        }
    }
}
