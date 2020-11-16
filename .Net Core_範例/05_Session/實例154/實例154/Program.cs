using System;

namespace 實例154
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "4.00012";
            double v1 = double.Parse(s1);

            Console.WriteLine(v1);

            string s2 = "2016-11-25";
            DateTime v2 = DateTime.Parse(s2);

            Console.WriteLine(v2);

            string s3 = "6507";
            bool b = short.TryParse(s3, out short v3);

            if(b)
            {
                Console.WriteLine(v3);
            }
            else
            {
                Console.WriteLine("無法轉為16進位");
            }

            Console.ReadKey();
        }
    }
}
