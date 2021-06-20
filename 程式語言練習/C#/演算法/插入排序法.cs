using System.Collections.Generic;
using static System.Console;

namespace ConsoleApp1
{

    class Program
    {
        static int size = 6;
        static int[] data = new int[size];

        static void Main(string[] args)
        {
            Inputarr();
            Write("您輸入的原始陣列是：");
            ShowArr();
            SortData();
            Write("排序後的陣列是：");
            ShowArr();
            ReadKey();
        }

        static void Inputarr()
        {
            for (int i = 0; i < size; i++)
            {
                int value;
                Write("請輸入第" + (i + 1) + "個元素：");

                while(!int.TryParse(ReadLine(), out value))
                {
                    WriteLine("輸入錯誤!!!請重新輸入");
                    Write("請輸入第" + (i + 1) + "個元素：");
                }
                data[i] = value;
            }
        }

        static void ShowArr()
        {
            foreach (int a in data)
                Write(a + " ");
            WriteLine();
        }

        static void SortData()
        {
            LinkedList<int> result = new LinkedList<int>();
            LinkedListNode<int> listed = null;
            for (int i = 0; i < data.Length; i++)
            {
                if (result.Count == 0)
                    result.AddFirst(data[i]);
                else
                {
                    while (listed != null)
                    {
                        if (data[i] < listed.Value)
                        {
                            result.AddBefore(listed, data[i]);
                            break;
                        }
                        else
                        {
                            if (listed.Next == null)
                            {
                                result.AddAfter(listed, data[i]);
                                break;
                            }
                            else
                                listed = listed.Next;
                        }
                    }
                }
                listed = result.First;
            }
            result.CopyTo(data, 0);
        }
    }
}
