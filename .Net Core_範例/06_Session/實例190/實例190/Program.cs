using System;

namespace 實例190
{
    class Program
    {
        static void Main(string[] args)
        {
            Test t = new Test();
            long r = t[800, 20000];

            Console.WriteLine($"計算結果：{r}");
        }
    }

    public class Test
    {
        public long this[int a,int b]
        { 
            get
            {
                return a * b;
            }
        }
    }
}
