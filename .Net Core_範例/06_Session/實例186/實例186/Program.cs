using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace 實例186
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Contact> set = new HashSet<Contact>(new ContactEqualityComparer());
            
            set.Add(new Contact
            {
                ID = 721001,
                Name = "老李",
                PhoneNo = "225325688"
            });

            Contact c1 = new Contact()
            {
                ID = 7412002,
                Name = "老何",
                PhoneNo = "1685584562"
            };

            Contact c2 = c1;
            set.Add(c1);
            set.Add(c2);

            Contact c3 = new Contact()
            {
                ID = 500002,
                Name = "老肖",
                PhoneNo = "170023"
            };

            Contact c4 = new Contact()
            {
                ID = 500002,
                Name = "老肖",
                PhoneNo = "170023"
            };

            set.Add(c3);
            set.Add(c4);
            

            foreach(var item in set)
            {
                string msg = $"身份標識：{item.ID}\n姓名：{item.Name}\n手機：{item.PhoneNo}\n";
                Console.WriteLine(msg);
            }
        }
    }

    public class Contact
    {
        public string Name { get; set; }
        public string PhoneNo { get; set; }
        public long ID { get; set; }
    }

    public sealed class ContactEqualityComparer : EqualityComparer<Contact>
    {
        public override bool Equals(Contact x, Contact y)
        {
            if (x == null || y == null)
                return false;
            if (object.ReferenceEquals(x, y))
                return true;
            if (x.ID == y.ID && x.Name == y.Name && x.PhoneNo == y.PhoneNo)
                return true;
            return false;
        }

        public override int GetHashCode(Contact obj)
        {
            return obj.ID.GetHashCode() ^ obj.Name.GetHashCode() ^ obj.PhoneNo.GetHashCode();
        }
    }

}
