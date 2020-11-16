using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 實例89
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    public enum ReadMode : byte
    {
        NewFile = 1, OpenCurrent = 2, Save = 3
    }

    public enum Picture : uint
    {
        HQ = 4, LQ = 12, MQ = 7
    }
}
