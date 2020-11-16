using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace 實例73
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 16, 21, 20, 11, 18, 37, 41, 77 };

            //int[] resarr = Array.FindAll(arr, element =>
            //{

            //    if ((element % 2) == 0 || (element % 3) == 0)
            //    {
            //        return true;
            //    }
            //    else
            //    {
            //        return false;
            //    }
            //});
            Predicate<int> predicate = Compare;

            int[] resarr = Array.FindAll(arr, predicate);

            Console.WriteLine("同時被2或3整除的整數有：");
            foreach(var a in resarr)
            {
                Console.Write(a + ",");
            }
        }

        static bool Compare(int element)
        {
            if ((element % 2) == 0 || (element % 3) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
