using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 實例55
{
    class Program
    {
        struct Rectangle
        {
            public int Width;
            public int Height;

            public Rectangle(int w,int h)
            {
                Width = w;
                Height = h;
            }
        }

        static void Main(string[] args)
        {
            Rectangle r1;
            r1.Height = 25;
            r1.Width = 10;

            Rectangle r2 = new Rectangle();
            r2.Width = 6;
            r2.Height = 17;

            Rectangle r3 = new Rectangle(45, 183);

        }
    }
}
