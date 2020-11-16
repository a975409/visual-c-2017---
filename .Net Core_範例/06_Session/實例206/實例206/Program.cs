using System;

namespace 實例206
{
    class Program
    {
        static void Main(string[] args)
        {
            Order o = new Order
            {
                OID = 6012001,
                CustomName = "貿易公司",
                ContactName = "劉先生",
                Amount = 1700.34f,
                PhoneNo = "13322500121"
            };

            var (id, cust, contact, amout, phone) = o;

            Console.WriteLine($"訂單編號：{id}");
            Console.WriteLine($"客戶單位：{cust}");
            Console.WriteLine($"聯絡人：{contact}");
            Console.WriteLine($"訂購數量：{amout}");
            Console.WriteLine($"電話：{phone}");
        }
    }

    public class Order
    { 
        public int OID { get; set; }
        public string CustomName { get; set; }
        public string ContactName { get; set; }
        public float Amount { get; set; }
        public string PhoneNo { get; set; }

        public void Deconstruct(out int oid, out string custName, out string contact, out float amount, out string phone)
        {
            oid = OID;
            custName = CustomName;
            contact = ContactName;
            amount = Amount;
            phone = PhoneNo;
        }
    }
}
