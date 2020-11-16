using System;
using System.Linq;

namespace 實例117
{
    struct Rectangle
    {
        public float Width;
        public float Height;
    }

    class Program
    {
        static Rectangle[] rects =
        {
            new Rectangle{Width=16.3f, Height=7f},
            new Rectangle{Width=24.5f, Height=10f},
            new Rectangle{Width=9.6f, Height=8.5f},
            new Rectangle{Width=4f, Height=12.3f},
        };

        static void Main(string[] args)
        {
            float lens = rects.Sum(r => (r.Width + r.Height) * 2f);

            Console.WriteLine($"以上{rects.GetLength(0)}個矩形的周長總和為：{lens}");
            Console.ReadKey();
        }
    }
}
