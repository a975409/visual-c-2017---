using System;
using System.Collections.Generic;

namespace 實例193
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, DateTime> dic = new SortedDictionary<string, DateTime>(new CustSortComparer());
            dic["ab"] = new DateTime(2018, 1, 1);
            dic["hijklmn"] = new DateTime(2018, 1, 3);
            dic["opqr"] = new DateTime(2018, 1, 5);
            dic["s"] = new DateTime(2018, 1, 7);
            dic["stuvwxyz"] = new DateTime(2018, 1, 9);

            foreach(var s in dic)
                Console.WriteLine($"{s.Key} - {s.Value}");
        }
    }

    public class CustSortComparer : Comparer<string>
    {
        public override int Compare(string x,  string y)
        {
            return x.Length - y.Length;
        }
    }
}
