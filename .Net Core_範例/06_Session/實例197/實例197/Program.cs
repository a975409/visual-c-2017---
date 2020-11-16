using System;
using System.Collections;

namespace 實例197
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();

            list.Add(5580);
            list.Add(7899878L);
            list.Add('V');

            list.RemoveAt(0);

            list.Add("test");
            list.Add((uint)36000);

            foreach(object o in list)
                Console.WriteLine(o);
        }
    }
}
