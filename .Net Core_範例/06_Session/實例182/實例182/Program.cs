using System;
using System.Collections.Generic;
using System.Collections;

namespace 實例182
{
    class Program
    {
        static void Main(string[] args)
        {
            Numbers nbs = new Numbers();
            foreach(decimal n in nbs)
            {
                Console.WriteLine(n);
            }
            
        }
    }

    public class Numbers:IEnumerable<decimal>
    {
        decimal[] numberarr = { 7.33m, 16.12m, 800.56m, 1202.633m, 170.9m };

        public IEnumerator<decimal> GetEnumerator()
        {
            return new NumberEnumerator(numberarr);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }


    internal class NumberEnumerator:IEnumerator<decimal>
    {
        decimal[] srcNumber;
        int currentIndex;

        public NumberEnumerator(decimal[] source)
        {
            srcNumber = source;
            currentIndex = -1;
        }

        public decimal Current { get;private set; }

        object IEnumerator.Current => Current;

        public void Dispose()
        {

        }

        public bool MoveNext()
        {
            if (++currentIndex >= srcNumber.Length)
            {
                Current = default;
                return false;
            }

            Current = srcNumber[currentIndex];
            return true;
        }

        public void Reset()
        {

        }
    }
}
