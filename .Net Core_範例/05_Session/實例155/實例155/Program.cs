using System;
using System.Text;

namespace 實例155
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "你好，小王。";

            byte[] data = Encoding.UTF8.GetBytes(str);
            Console.WriteLine("utf-8編碼後的位元組序列：\n{0}", BitConverter.ToString(data));

            string back = Encoding.UTF8.GetString(data);
            Console.WriteLine("從utf-8編碼後的位元組序列讀回原本的字串：\n{0}", back);

            Console.ReadKey();
        }
    }
}
