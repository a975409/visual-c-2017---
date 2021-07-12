using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
			//1. 用 if else, else if 語法, 求得任意三個數的最大值結果.
			
            int[] result = new int[3];
            int maxValue = 0, i = 0;

            while (i < result.Length)
            {
                Console.Write("請輸入第{0}個值：", i + 1);
                if (int.TryParse(Console.ReadLine(), out result[i]))
                {
                    if (i == 0 || result[i] > maxValue)
                        maxValue = result[i];
                    i++;
                }
                else
                {
                    Console.WriteLine("請輸入正確數值!!");
                }
            }

            Console.WriteLine("輸入三個數最大值：{0}", maxValue);
			
			//2. 將Switch甜點單餐範例, 改成無窮迴圈while
			//請輸入甜點代號(1:布丁, 2:冰淇淋, 3:奶酪, 4:紅豆湯, e:結束選單)
			//提示: while; break; bool 值變數; Console.Clear();
			
			string no = "";
            bool run = true;

            while(run)
            {
                Console.Write("請輸入甜點代號(1:布丁, 2:冰淇淋, 3:奶酪, 4:紅豆湯, e:結束選單)：");
                no = Console.ReadLine();

                switch(no)
                {
                    case "1":
                        Console.WriteLine("您點了布丁");
                        run = false;
                        break;
                    case "2":
                        Console.WriteLine("您點了冰淇淋");
                        run = false;
                        break;
                    case "3":
                        Console.WriteLine("您點了奶酪");
                        run = false;
                        break;
                    case "4":
                        Console.WriteLine("您點了紅豆湯");
                        run = false;
                        break;
                    case "e":
                        Console.WriteLine("結束選單");
                        run = false;
                        break;
                    default:
                        Console.WriteLine("未知錯誤，請重新輸入!!");
                        Console.Clear();
                        break;
                }
            }

            Console.ReadKey();
        }
    }

}
