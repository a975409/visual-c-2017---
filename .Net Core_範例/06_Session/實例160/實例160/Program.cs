using System;

namespace 實例160
{
    class Program
    {
        static void Main(string[] args)
        {
            Tets<int> tv = new Tets<int>();
            tv.Start(100);

            Tets<byte> tq = new Tets<byte>();
            tq.Start(152);
        }
    }

    class Tets<T> where T:struct
    { 
        public void Start(T x)
        {
            string CheckType(Type t) => t.IsValueType ? "是" : "否";
            Type type = x.GetType();
            Console.WriteLine($"{type.Name}{CheckType(type)}數值型態");
        }
    }

}
