using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 實例83
{
    class Program
    {
        static void Main(string[] args)
        {
            using (TextWriter wt=new TextWriter())
            {
                wt.WriteText("程式設計真好玩");
            }
        }
    }
}
