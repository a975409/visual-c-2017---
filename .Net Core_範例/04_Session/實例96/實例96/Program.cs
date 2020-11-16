using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 實例96
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public class CustomAttribute : Attribute
    {
        public string Ver { get; set; }
    }

    [Custom(Ver ="1.0.0.1"),Custom(Ver ="1.0.2.0")]
    public class AppData
    { 
        
    }
}
