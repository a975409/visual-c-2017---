using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 實例61
{
    class Program
    {
        static void Main(string[] args)
        {
            Product pro = new Product();
            pro.Name = "測試產品A";
            pro.Code = 60009;
            Console.WriteLine("呼叫Update前：" + pro.Name + pro.Code);
            Update(ref pro);
            Console.WriteLine("呼叫Update後：" + pro.Name + pro.Code);
            Console.ReadKey();
        }
        static void Update(ref Product p)
        {
            p = new Product
            {
                Code = 700021,
                Name = "測試產品C"
            };
        }
    }
}
