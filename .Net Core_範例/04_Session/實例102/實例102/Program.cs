using System;
using System.Reflection;

namespace 實例102
{
    class Program
    {
        static void Main(string[] args)
        {
            Type t = typeof(Person);

            Console.WriteLine($"完整類別名稱：{t.FullName}");
            Console.WriteLine("是否為抽象類別：{0}", t.IsAbstract ? "是" : "否");
            Console.WriteLine("是否為公共類別：{0}", t.IsPublic ? "是" : "否");

            PropertyInfo[] props = t.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            Console.WriteLine("\n\n-----屬性清單-----");
            foreach(var p in props)
            {
                Console.WriteLine($"{p.Name,-15}{p.PropertyType.Name}");
            }

            Console.ReadKey();
        }
    }

    public abstract class Person
    {
        public abstract int Age { get; set; }
    }
}
