using System;

namespace 實例207
{
    class Program
    {
        static void Main(string[] args)
        {
            var k = GetData();

            Console.WriteLine("未對欄位重新命名：");
            Console.WriteLine("Item1 = {0},Item2 = {1},Item3 = {2}", k.Item1, k.Item2, k.Item3);

            var (Mark1, Count, Mark2) = GetData();

            Console.WriteLine("對欄位重新命名：");
            Console.WriteLine($"{nameof(Mark1)}:{Mark1} , {nameof(Count)}:{Count} , {nameof(Mark2)}:{Mark2}");

            var d = GetNumbers();

            Console.WriteLine("\n傳回帶重新命名各欄位的元組：");
            Console.WriteLine($"{nameof(d.Number1)}:{d.Number1} , {nameof(d.Number2)}:{d.Number2}");
        }

        static (string,int,string) GetData()
        {
            return ("Test 1", 35, "Test 2");
        }

        static(int Number1,int Number2) GetNumbers()
        {
            Random rand = new Random();
            return (rand.Next(0, 1000), rand.Next(0, 1000));
        }
    }
}
