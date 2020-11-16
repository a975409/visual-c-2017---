using System;
using System.Reflection;

namespace 實例204
{
    class Program
    {
        static void Main(string[] args)
        {

            (double x, double y) d = (0.000025d, 3.115d);
            Console.WriteLine("x * y ={0}", d.x * d.y);

            Type t = d.GetType();

            var fds = t.GetFields(BindingFlags.Public | BindingFlags.Instance);

            Console.WriteLine("元組的執行時期類型：{0}", t.Name);
            string infos = string.Empty;

            foreach(var f in fds)
            {
                infos += $"{f.Name}:{f.FieldType.Name}\n";
            }

            Console.WriteLine("各欄位名稱與類型：\n{0}", infos);
        }
    }
}
