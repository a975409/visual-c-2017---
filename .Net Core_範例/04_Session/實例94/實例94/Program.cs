using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 實例94
{
    class Program
    {
        static void Main(string[] args)
        {


        }
    }

    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Method)]
    public class MyDemoAttribute : Attribute
    {
        public string Description { get; set; }
    }

    public class Order
    {
        [MyDemo(Description ="訂單ID")]
        public int OdrID { get; set; }

        [MyDemo(Description = "增加時間")]
        public DateTime AddTime { get; set; }

        [MyDemo(Description = "計算折扣價")]
        public double Compute(double q)
        {
            return q * 0.98d;
        }
    }
}
