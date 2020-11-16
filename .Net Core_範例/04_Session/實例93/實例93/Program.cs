using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 實例93
{
    class Program
    {
        static void Main(string[] args)
        {
            Test t = Test.Model2 | Test.Model3;
            bool b = t.HasFlag(Test.Model3);

            Test t2 = Test.Model1 | Test.Model2 | Test.Model3;
            bool b2 = (t2 & Test.Model1) == Test.Model1;
        }
    }
    enum Test
    {
        Model1, Model2, Model3
    }
}
