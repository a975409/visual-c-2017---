using System;
using System.Collections.Generic;

namespace 實例178
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<int> list = new SortedSet<int>(new MyCompare());
            list.Add(15);
            list.Add(2);
            list.Add(25);
            list.Add(13);
            list.Add(7);
            
            foreach(int a in list)
            {
                Console.WriteLine(a);
            }
        }
    }

    public class MyCompare : Comparer<int>
    {
        public override int Compare(int x, int y)
        {
            //throw new NotImplementedException();

            return -(x - y);
        }
    }
}
