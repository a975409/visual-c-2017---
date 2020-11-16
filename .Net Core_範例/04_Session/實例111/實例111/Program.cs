using System;

namespace 實例111
{
    class Program
    {
        static void Main(string[] args)
        {
            RecArea v = new RecArea(12, 15);
            int area = v;
            Console.WriteLine($"矩形資訊：\n寬：{v.Width}\n高：{v.Height}\n面積：{area}");
            Console.ReadKey();
        }
    }

    public class RecArea
    {
        public int Width { get; }
        public int Height { get; }

        public RecArea(int width,int height)
        {
            Width = width;
            Height = height;
        }

        public static implicit operator int(RecArea r)
        {
            return r.Width * r.Height;
        }
    }
}
