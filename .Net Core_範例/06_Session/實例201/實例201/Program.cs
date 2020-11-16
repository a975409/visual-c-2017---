using System;

namespace 實例201
{
    class Program
    {
        static void Main(string[] args)
        {
            Tuple<string, string, string> t1 = new Tuple<string, string, string>("make", "it", "easy");

            Console.WriteLine("三元組：");
            string msg = $"{nameof(t1.Item1)}:{t1.Item1.GetType().Name} = {t1.Item1}\n" +
                $"{nameof(t1.Item2)}:{t1.Item2.GetType().Name} = {t1.Item2}\n" +
                $"{nameof(t1.Item3)}:{t1.Item3.GetType().Name} = {t1.Item3}\n";

            Console.WriteLine(msg);

            Tuple<int, uint> t2 = new Tuple<int, uint>(70000, 950000);

            Console.WriteLine("二元組：");
            msg = $"{nameof(t2.Item1)}:{t2.Item1.GetType().Name} = {t2.Item1}\n" +
                $"{nameof(t2.Item2)}:{t2.Item2.GetType().Name} = {t2.Item2}\n";

            Console.WriteLine(msg);
        }
    }
}
