using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Fib
{
    class Program
    {
        static int[] output = new int[1000];
        static void Main(string[] args)
        {
            int num;
            string str;
            WriteLine("使用遞迴計算費氏級數");
            Write("請輸入一個整數：");
            str = ReadLine();
            num = int.Parse(str);

            if(num<0)
            {
                WriteLine("輸入數字必須大於0");
            }
            else
            {
                WriteLine("Fibonacci(" + num + ")=" + Fibonacci_Save(num));
            }

            ReadKey();
        }

        static int Fibonacci_Save(int n)
        {
            int result = output[n];

            if(result == 0)
            {
                if (n == 0)
                    output[n] = 0;
                else if (n == 1)
                    output[n] = 1;
                else
                    output[n] = Fibonacci(n - 1) + Fibonacci(n - 2);
                result = output[n];
            }
            return result;
        }

        static int Fibonacci(int n)
        {
            if (n == 0)
                return 0;
            else if (n == 1)
                return 1;
            else
                return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}
