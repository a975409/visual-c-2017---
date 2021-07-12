using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 單行註解
            /*
             多行註解 
             不只一行 
              
             */
            System.Console.WriteLine("Hi, 這是第一個Console程式");
            System.Console.Write("C# Demo");
            System.Console.Write(" - Console1App");
            System.Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("1. 主控台應用程式");
            Console.WriteLine("2. Windows Form應用程式");
            Console.WriteLine("3. 網頁應用程式");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("輸出用特殊符號");
            Console.WriteLine("\"雙引號\"");
            Console.WriteLine("\'單引號\'");
            Console.WriteLine("\\反斜線\\");
            Console.WriteLine("換\n行\n功\n能");
            Console.WriteLine("\t縮排");
            Console.WriteLine("------------------------------");
            Console.WriteLine("按任一鍵結束");
            System.Console.ReadKey();
        }
    }
}
