using System;
using System.Collections.Generic;

namespace 實例191
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> st = new Stack<int>();
            st.Push(3);
            st.Push(2);
            st.Push(1);

            //while(st.Count>0)
            //{
            //    Console.WriteLine(st.Pop());
            //}

            while(st.TryPop(out int x))
            {
                Console.WriteLine(x);
            }

            //Console.WriteLine("Hello World!");
        }
    }
}
