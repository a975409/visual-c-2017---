using System;

namespace 實例98
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        [return:CheckSum]
        static string SaySomething() => "Hello";
    }

    [AttributeUsage(AttributeTargets.ReturnValue)]
    public class CheckSumAttribute : Attribute
    {

    }
}
