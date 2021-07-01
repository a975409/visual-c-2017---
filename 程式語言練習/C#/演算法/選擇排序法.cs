using System;
using System.Linq;
using System.Collections.Generic;
using static System.Console;

namespace ConsoleApp1
{

    class Program
    {
        static int process = 0;
        static int[] data = { 59, 95, 7, 34, 60, 168, 171, 259, 372, 45, 88, 133 };

        static void Main(string[] args)
        {
            WriteLine("原始資料：");
            Showdata();
            SortData(data);
            WriteLine("排序後資料：");
            Showdata();
            ReadKey();
        }

        static void Showdata()
        {
            foreach (int i in data)
                Write(i + " ");
            WriteLine();
        }

        static void SortData(int[] data)
        {
            bool change;
            int minValue, minIdx = -1;
            for (int i = 1; i < data.Length; i++)
            {
                change = false;
                minValue = data[i - 1];
                for (int j = i - 1; j < data.Length; j++)
                {
                    if (data[j] < minValue)
                    {
                        minValue = data[j];
                        minIdx = j;
                        change = true;
                    }
                }

                if(change)
                {
                    data[minIdx] = data[i - 1];
                    data[i - 1] = minValue;
                }

                Write($"第{++process}次排序：");
                Showdata();
            }
        }
    }
}
