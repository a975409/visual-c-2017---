using System;
using System.Collections.Generic;

namespace 實例194
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> q = new Queue<int>();

            q.Enqueue(3);
            q.Enqueue(2);
            q.Enqueue(1);


            while(q.TryDequeue(out int a))
                Console.WriteLine(a);
        }
    }
}
