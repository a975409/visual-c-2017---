using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Iterative
{
    class Program
    {
        static void Main(string[] args)
        {

            int sum = 1;

            Write("請從鍵盤輸入n=");
            int n = int.Parse(ReadLine());

            for(int i=1;i<n+1;i++)
            {
                for(int j=i;j>0;j--)
                {
                    sum *= j;
                }
                WriteLine(i + "!=" + sum);
                sum = 1;
            }

            ReadKey();
        }
    }
}
