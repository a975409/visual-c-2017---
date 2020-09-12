using System;

namespace 實例56
{
    class Program
    {
        static void Main(string[] args)
        {
            Production p1 = new Production();
            Console.WriteLine($"產品編號:{p1.ProductID}\n產品名稱:{p1.ProductName}\n生產日期:{p1.ProductDate:D}\n");

            Production p2 = new Production("範例產品", new DateTime(2017, 12, 12));
            Console.WriteLine($"產品編號:{p2.ProductID}\n產品名稱:{p2.ProductName}\n生產日期:{p2.ProductDate:D}");

            Console.ReadKey();
        }
    }

    public class Production
    {
        public Guid ProductID { get; set; }
        public string ProductName { get; set; }
        public DateTime ProductDate { get; set; }
        
        public Production(Guid pid,string pname,DateTime pdate)
        {
            ProductID = pid;
            ProductName = pname;
            ProductDate = pdate;
        }

        public Production(string pname, DateTime pdate) : this(Guid.NewGuid(), pname, pdate) { }
    
        public Production() : this(Guid.NewGuid(), "未知產品", DateTime.Today) { }
    }
}
