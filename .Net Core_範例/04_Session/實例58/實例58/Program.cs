using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 實例58
{
    class Program
    {
        static void Main(string[] args)
        {
            User u = new User();

            try
            {
                u.Username = "Tom";
                u.Password = "****";
            }
            catch(Exception ex)
            {
                Console.WriteLine("錯誤：" + ex.Message);
            }
            Console.ReadKey();
        }
    }
}
