using System;
using System.Reflection;

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

        static bool CheckTest(Test t, string property)
        {
            Type type = t.GetType();

            //尋找屬性成員
            PropertyInfo prop = type.GetProperty(property, BindingFlags.Public | BindingFlags.Instance);

            if (prop == null)
                return false;

            //取得屬性成員的特性
            MyAttribute att = prop.GetCustomAttribute<MyAttribute>();

            //取得實例的屬性值
            string value = prop.GetValue(t) as string;
            if (string.IsNullOrEmpty(value))
                return false;

            //進行驗證
            if (value.StartsWith(att.StartChar) == false)
                return false;

            if (value.Length > att.MaxLen)
                return false;

            return true;
        }

    }
    [AttributeUsage(AttributeTargets.Property)]
    class MyAttribute : Attribute
    {
        public char StartChar { get; set; }
        public int MaxLen { get; set; }
    }

    class Test
    {
        [My(StartChar = 'k', MaxLen = 7)]
        public string RawName { get; set; }
    }
    
}
