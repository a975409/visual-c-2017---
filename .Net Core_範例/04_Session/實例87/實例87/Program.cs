using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 實例87
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = new
            {
                Color = "白色",
                Size = 43.6f,
                Number = 7988
            };

            string str = $"顏色：{x.Color}\n尺碼：{x.Size}\n編號：{x.Number}\n";

            Console.WriteLine("商品資訊：" + str);
            Console.ReadKey();
        }
    }
}
