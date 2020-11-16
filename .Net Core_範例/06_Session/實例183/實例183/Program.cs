using System;
using System.Collections;
using System.Collections.Generic;

namespace 實例183
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach(var item in Test1())
            {
                Console.WriteLine(item);
            }

            foreach (var item in Test2())
            {
                Console.WriteLine(item);
            }
        }

        static IEnumerable Test1()
        {
            yield return 0;
            yield return 1;
            yield return 2;
        }

        static IEnumerable<string> Test2()
        {
            yield return "abcd";
            yield return "opqrs";
            yield return "csanln";
        }

        
    }
}
