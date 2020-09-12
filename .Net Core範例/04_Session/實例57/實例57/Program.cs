using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 實例57
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test.Sample);
            Console.WriteLine(Test.Sample);
            Console.WriteLine(Test.Sample);
            Console.ReadKey();
        }
    }

    public class Test
    {
        public static string Sample { get; }

        static Test()
        {
            Sample = "示範屬性";
            Console.WriteLine("靜態建置函數被呼叫");
        }
    }
}
