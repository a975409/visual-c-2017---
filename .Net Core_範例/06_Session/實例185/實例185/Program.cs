using System;
using System.Collections.Generic;

namespace 實例185
{
    class Program
    {
        static void Main(string[] args)
        {

            LinkedList<string> list = new LinkedList<string>();

            var node = list.AddFirst("a");
            node = list.AddAfter(node,"b");
            node = list.AddAfter(node, "c");
            node = list.AddAfter(node, "d");
            list.AddBefore(node, "0");

            foreach(var item in node.List)
                Console.WriteLine(item);

            LinkedList<byte> list2 = new LinkedList<byte>();

            list2.AddLast(1);
            list2.AddLast(3);
            list2.AddLast(2);
            list2.AddLast(4);

            var foundnode = list2.Find(3);

            var thirnode = foundnode.Next;

            list2.Remove(foundnode);

            list2.AddAfter(thirnode, foundnode.Value);

            foreach (var i in list2)
                Console.WriteLine(i);
        }
    }
}
