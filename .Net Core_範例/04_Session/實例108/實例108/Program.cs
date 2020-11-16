using System;
using System.Text;

namespace 實例108
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] buffer = { 3, 12, 5, 92, 7, 61, 18, 53, 135 };
            //string str = Convert.ToBase64String(buffer);
            string str = BitConverter.ToString(buffer);
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
