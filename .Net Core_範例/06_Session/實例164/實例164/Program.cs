using System;

namespace 實例164
{
    class Program
    {
        public delegate R MyTestDel<in A1, in A2, out R>(A1 m, A2 n) where A1 : struct where A2 : struct;

        static void Main(string[] args)
        {
            MyTestDel<int, byte, string> test = (a, b) =>
              {
                  string ret = $"type={a.GetType().Name},value={a}\ntype={b.GetType().Name},value={b}";
                  return ret;
              };

            Console.WriteLine(test(350, 27));
        }
    }
}
