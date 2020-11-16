using System;
using System.Text;

namespace 實例140
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine("Happy !")
                .Append("abc")
                .Append("-")
                .Append("xyz")
                .AppendFormat("0x{0:x}={0}\n", 144650)
                .AppendJoin('~', 50, false, 3.6625d)
                .AppendLine()
                .Replace("Happy", "Hello Jim");

            Console.WriteLine(builder);
            Console.ReadKey();
        }
    }
}
