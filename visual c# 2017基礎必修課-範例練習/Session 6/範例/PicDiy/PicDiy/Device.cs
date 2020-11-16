using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PicDiy
{
    public class Device
    {
        public string pc { get; }
        public int price { get; }

        public Device(string pc, int price)
        {
            this.pc = pc;
            this.price = price;
        }
    }
}
