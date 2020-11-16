using System;

namespace 實例109
{
    class Program
    {
        static void Main(string[] args)
        {
            Production[] prs =
            {
                new Production
                {
                    ID=1,
                    Width=150,
                    Height=70,
                    SerialNum="T-312756-K3"
                },
                new Production
                {
                    ID=2,
                    Width=200,
                    Height=85,
                    SerialNum="T-312756-K7"
                }
            };

            foreach(Production p in prs)
            {
                Console.WriteLine(p.ToString());
            }

            Console.ReadKey();
        }
    }

    public class Production
    { 
        public int ID { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string SerialNum { get; set; }

        public override string ToString()
        {
            return $"產品序號：{SerialNum}，規格(公釐)：{Width} X {Height}";
        }
    }
}
