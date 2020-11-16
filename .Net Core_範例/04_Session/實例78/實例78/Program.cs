using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

interface IRunner1
{
    void StartWork();
}

interface IRunner2
{
    void EndWork();
}

namespace 實例78
{
    class Program
    {
        static void Main(string[] args)
        {
            OneWork oneWork = new OneWork();

            oneWork.StartWork();
            oneWork.EndWork();

            Console.ReadKey();
        }
    }

    class OneWork : IRunner1, IRunner2
    {
        public void EndWork()
        {
            Console.WriteLine("結束操作");
        }

        public void StartWork()
        {
            Console.WriteLine("開始操作");
        }
    }
}
