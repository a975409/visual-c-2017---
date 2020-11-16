using System;

namespace 實例165
{
    class Program
    {
        static void Main(string[] args)
        {
            TestAnl<Animal> anl = new TestAnl<Animal>();
            anl.Work(new Meerket());
            //Console.WriteLine("Hello World!");

            ITest1<Animal> test1 = new TestAnl<Animal>();
            test1.Work(new Fox());
        }
    }

    public abstract class Animal
    {
        public abstract void CheckIn();
    }

    public class Meerket : Animal
    {
        public override void CheckIn()
        {
            Console.WriteLine("這是貓鼬");
            //throw new NotImplementedException();
        }
    }

    public class Fox:Animal
    {
        public override void CheckIn()
        {
            Console.WriteLine("這是狐狸");
            //throw new NotImplementedException();
        }
    }

    public class Chicken:Animal
    {
        public override void CheckIn()
        {
            Console.WriteLine("這是雞");
            //throw new NotImplementedException();
        }
    }

    public class Quail:Animal
    {
        public override void CheckIn()
        {
            Console.WriteLine("這是鵪鶉");
            //throw new NotImplementedException();
        }
    }

    public interface ITest1<in T>
    {
        void Work(T pr);
    }

    public class TestAnl<T> : ITest1<T> where T : Animal
    {
        public void Work(T pr) 
        {
            pr.CheckIn();
        }
    }
}
