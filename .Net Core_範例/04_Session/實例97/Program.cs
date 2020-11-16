using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace 實例97
{
    class Program
    {
        static void Main(string[] args)
        {
            Test v = new Test { RawName = "k003d6ex915f" };
            bool b = CheckTest(v, nameof(Test.RawName));

            if (b)
                Console.WriteLine("驗證通過");
            else
                Console.WriteLine("驗證失敗");

            Console.ReadKey();
        }

        static bool CheckTest(Test t,string property)
        {
            Type type = t.GetType();

            PropertyInfo prop = type.GetProperty(property, BindingFlags.Public | BindingFlags.Instance);

            if(prop ==null)
                return false;
            

            MyAttribute att = prop.GetCustomAttribute<MyAttribute>();

            string value = prop.GetValue(t) as string;
            if(string.IsNullOrEmpty(value))
                return false;
            

            if(value.StartsWith(att.StartChar)==false)
                return false;
            

            if (value.Length > att.MaxLen)
                return false;

            return true;
        }
    }

    [AttributeUsage(AttributeTargets.Property)]
    public class MyAttribute : Attribute
    {
        public char StartChar { get; set; }
        public int MaxLen { get; set; }
    }

    public class Test
    {
        [My(StartChar = 'k', MaxLen = 7)]
        public string RawName { get; set; }
    }
}
