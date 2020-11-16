using System;
using System.Text;

namespace 實例202
{
    class Program
    {
        static void Main(string[] args)
        {
            ValueTuple<short, uint, ulong, string> t1 = ValueTuple.Create<short, uint, ulong, string>(160, 300, 50000000UL, "head");

            StringBuilder strbd = new StringBuilder();

            strbd.AppendLine("四元組：");

            strbd.AppendFormat("{0}:{1} = {2}\n", nameof(t1.Item1), t1.Item1.GetType().Name, t1.Item1);
            strbd.AppendFormat("{0}:{1} = {2}\n", nameof(t1.Item2), t1.Item2.GetType().Name, t1.Item2);
            strbd.AppendFormat("{0}:{1} = {2}\n", nameof(t1.Item3), t1.Item3.GetType().Name, t1.Item3);
            strbd.AppendFormat("{0}:{1} = {2}\n", nameof(t1.Item4), t1.Item4.GetType().Name, t1.Item4);

            

            ValueTuple<bool, byte> t2 = ValueTuple.Create<bool, byte>(false, 100);

            strbd.AppendLine("\n\n二元組：");
            strbd.AppendFormat("{0}:{1} = {2}\n", nameof(t2.Item1), t2.Item1.GetType().Name, t2.Item1);
            strbd.AppendFormat("{0}:{1} = {2}\n", nameof(t2.Item2), t2.Item2.GetType().Name, t2.Item2);

            t2.Item2 = 210;

            strbd.AppendFormat("修改後：{0} = {1}", nameof(t2.Item2), t2.Item2);

            Console.WriteLine(strbd);
        }
    }
}
