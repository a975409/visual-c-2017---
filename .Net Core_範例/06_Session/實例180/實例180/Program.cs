using System;
using System.Collections;
using System.Collections.Generic;

namespace 實例180
{
    class Program
    {
        static void Main(string[] args)
        {
            

            using (MyEnum tn = new MyEnum())
            {
                while (tn.MoveNext())
                {
                    Console.WriteLine(tn.Current);
                }

                
            }
        }
    }

    class MyEnum : IEnumerator<int>
    {
        Random rdn = null;
        int count;

        public MyEnum()
        {
            rdn = new Random();
            count = 0;
            Current = default(int);
        }

        public int Current { get; private set; }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }
        
        public bool MoveNext()
        {
            if (++count > 10)
                return false;
            Current = rdn.Next();
            return true;
        }

        public void Dispose()
        {
            rdn = null;
        }

        public void Reset()
        {
            Current = default(int);
            count = 0;
        }

    }
}
