using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 實例64
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("-------不使用按參考傳遞的傳回值-------");
            Test1 t1 = new Test1(100);
            Console.WriteLine("初值");
            t1.DisplayValue();
            int x = t1.Value;
            x = 200;
            Console.WriteLine("修改屬性傳回值後");
            t1.DisplayValue();

            Console.WriteLine("\n-------使用按參考傳遞的傳回值-------");
            Test2 t2 = new Test2(100);
            Console.WriteLine("初值");
            t2.DisplayValue();
            ref int y = ref t2.Value;
            y = 200;
            Console.WriteLine("修改屬性傳回值後");
            t2.DisplayValue();

            Console.ReadKey();
        }
    }

    class Test1
    {
        private int _local;

        public Test1(int init)
        {
            _local = init;
        }

        public void DisplayValue()
        {
            Console.WriteLine($"目前值：{_local}");
        }

        public int Value => _local;
    }

    class Test2
    {
        private int _local;

        public Test2(int init)
        {
            _local = init;
        }

        public void DisplayValue()
        {
            Console.WriteLine($"目前值：{_local}");
        }

        public ref int Value => ref _local;
    }
}
