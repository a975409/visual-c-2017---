using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 實例95
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
    public class DoubleRangeAttribute : Attribute
    {
        public double Largest { get; }

        public DoubleRangeAttribute(double largest)
        {
            Largest = largest;
        }
    }

    [DoubleRange(700d)]
    public class Test
    { }
}
