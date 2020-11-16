using System;

namespace 實例162
{
    class Program
    {
        static void Main(string[] args)
        {
            (string Name, int Val) res = CallTest(Oper.Open);
            Console.WriteLine($"列舉常數名：{res.Name}，常數值：{res.Val}");
        }

        static (string, int) CallTest<T>(T p) where T : Enum
        {
            string name = Enum.GetName(p.GetType(), p);
            int Value = Convert.ToInt32(p);

            return (name, Value);
        }
    }

    public enum Oper
    {
        Open = 5, Close = 12, Reset = 6
    }
}
