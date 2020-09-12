using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace 實例46
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list1 = new List<string>();

            for (int i = 8; i > 0; i--)
            {
                string s1 = "";
                for (int j = 0; j < i; j++)
                {
                    s1 += "*";
                }
                s1 = s1.PadRight(8);

                //for (int k = 8 - i; k > 0; k--)
                //{
                //    s1 += "-";
                //}
                string s2 = new string(s1.Reverse().ToArray());
                list1.Add(s1 + s2);
            }

            foreach (var s in list1)
            {
                WriteLine(s);
            }
            list1.Reverse();
            foreach (var s1 in list1)
            {
                WriteLine(s1);
            }
            ReadKey();
        }
    }
}
