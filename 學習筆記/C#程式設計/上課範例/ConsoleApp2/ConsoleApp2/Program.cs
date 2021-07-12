using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //變數的宣告 variable
            short a;
            a = -289; //賦值, 指定
            int amount = 250;
            long count = 3500000000;
            //無正負號整數
            ushort age = 60;
            uint price = 10000;
            ulong total = 5000000000000000;
            //浮點數
            float average = 88.32f;
            double pi = 3.141592; //預設
            //boolean
            bool ifSucess = true;
            bool ifFinish = false;
            //字串
            string name = "王大衛";
            string tel = "0912-345-678";
            string email = "test@test.com.tw";
            //字元
            char myChar = 'x';
            char myChar2 = '微';

            Console.WriteLine("姓名:" + name + "\n" + "Tel:" + tel);
            Console.WriteLine("年齡:" + age + "\n" + "成績平均:" + average);
            Console.WriteLine(age + price);
            Console.WriteLine("是否成功" + ifSucess);
            Console.WriteLine("字元輸出" + myChar + myChar2);

            //字串插值
            Console.WriteLine("姓名是{0}, 年齡是{1}, 電話是{2}", name, age, tel);
            Console.WriteLine("考試通過了嗎?{0}, 年齡是{2}, 電話{1}, 學校:{3}",ifSucess,tel,age,"樂活國小");
            Console.WriteLine($"姓名是{name}, 年齡是{age}, 電話是{tel}");
            Console.ReadKey();



        }
    }
}
