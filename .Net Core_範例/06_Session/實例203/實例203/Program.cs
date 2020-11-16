using System;

namespace 實例203
{
    class Program
    {
        static void Main(string[] args)
        {
            (string, string, byte) x = ("subject", "body", 26);


            Console.WriteLine("三元組：\n{0} = {1}",nameof(x.Item1),x.Item1);
            Console.WriteLine("{0} = {1}", nameof(x.Item2), x.Item2);
            Console.WriteLine("{0} = {1}", nameof(x.Item3), x.Item3);

            var y = (new DateTime(2017, 1, 1), new DateTime(2018, 1, 1));

            Console.WriteLine("二元組：\n{0} = {1}", nameof(y.Item1), y.Item1);
            Console.WriteLine("{0} = {1}", nameof(y.Item2), y.Item2);

        }
    }
}
