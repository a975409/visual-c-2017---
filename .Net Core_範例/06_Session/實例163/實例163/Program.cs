using System;

namespace 實例163
{
    class Program
    {
        static void Main(string[] args)
        {
            ITest1<FootBall> t1 = new Test1<Ball>();
            ITest2<Ball> t2 = new Test2<FootBall>();

            Console.WriteLine("Hello World!");
        }
    }

    public class Ball { }
    public class FootBall : Ball { }

    public interface ITest1<in T> { }
    public interface ITest2<out T> { }

    public class Test1<T> : ITest1<T> { }
    public class Test2<T> : ITest2<T> { }
}
