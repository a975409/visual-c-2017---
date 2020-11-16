using System;
using System.Collections.Generic;
using System.Collections;

namespace 實例181
{
    class Program
    {
        static void Main(string[] args)
        {
            MyExampleCollection en = new MyExampleCollection();

            foreach(var a in en)
                Console.WriteLine(a);


        }
    }

    internal class MyEnum:IEnumerator
    {
        string[] _arr;
        int _currentIndex;

        public MyEnum(string[] src)
        {
            _arr = src;
            _currentIndex = -1;
        }

        public object Current { get; private set; }

        public bool MoveNext()
        {
            if (++_currentIndex >= _arr.Length)
            {
                Current = null;
                return false;
            }

            Current = _arr[_currentIndex];
            return true;
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

    }

    public class MyExampleCollection:IEnumerable
    {
        string[] arraySrc = { "red", "blue", "green", "gray" };

        public IEnumerator GetEnumerator()
        {
            return new MyEnum(arraySrc);
        }
    }
}
