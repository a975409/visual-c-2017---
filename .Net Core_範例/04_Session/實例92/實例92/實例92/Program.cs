using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 實例92
{
    class Program
    {
        static string[] days = Enum.GetNames(typeof(DayOfWeek));
        static void Main(string[] args)
        {
            foreach (string d in days)
            {
                Console.WriteLine(d);
            }
            Console.ReadKey();
        }
    }
}
