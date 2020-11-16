using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 實例84
{
    interface IDownloader
    {
        void Start();
    }

    interface IUploader
    {
        void Start();
    }

    class NetworkManager : IDownloader, IUploader
    {
        void IDownloader.Start() 
        {
            Console.WriteLine("正在下載中");
        }

        void IUploader.Start()
        {
            Console.WriteLine("正在上傳中");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            NetworkManager mng = new NetworkManager();
            IDownloader d1 = mng;
            d1.Start();
            IUploader u1 = mng;
            u1.Start();
            Console.ReadKey();

        }
    }
}
