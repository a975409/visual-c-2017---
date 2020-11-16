using System;
using System.Collections;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //MyEnum en = new MyEnum();

            //while(en.MoveNext())
            //{
            //    Console.WriteLine(en.Current);
            //}

            EnumTest ts = new EnumTest();

            foreach(var a in ts)
            {
                Console.WriteLine(a);
            }
            
        }
    }
    public class EnumTest:IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            return new MyEnum();
        }
    }


    public class MyEnum:IEnumerator
    {
        int count;
        int _current;
        Random rand;

        public MyEnum()
        {
            count = 0;
            _current = 0;
            rand = new Random();
        }

        public object Current
        {
            get
            {
                return _current;
            }
        }

        public bool MoveNext()
        {
            if (++count > 10)
                return false;

            _current = rand.Next();
            return true;
        }

        public void Reset()
        {
            count = 0;
            _current = 0;
        }
    }
}
