using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 實例80
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Camara c = Camara.CurrentInstance;
            Console.WriteLine($"裝置標識：{c.DeviceID}");
            Console.ReadKey();
        }
    }

}
