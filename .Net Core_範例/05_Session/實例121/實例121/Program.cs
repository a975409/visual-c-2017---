using System;
using System.Numerics;

namespace 實例121
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 300;
            BigInteger bi = 1;
            int temp = n;

            while(temp>0)
            {
                bi *= temp;
                temp--;
            }

            Console.WriteLine($"{n}的階層：\n{bi}");

            Console.ReadKey();
        }
    }
}
