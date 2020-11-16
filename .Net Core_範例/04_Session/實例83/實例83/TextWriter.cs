using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 實例83
{
    class TextWriter : IDisposable
    {
        const string FILE_NAME = "demo.txt";

        FileStream fsWrite = null;

        public TextWriter()
        {
            fsWrite = File.OpenWrite(FILE_NAME);
        }

        public void WriteText(string str)
        {
            byte[] data = Encoding.UTF8.GetBytes(str);

            fsWrite.Write(data, 0, data.Length);
            fsWrite.Flush();
        }

        public void Dispose()
        {
            fsWrite?.Close();
            fsWrite?.Dispose();
        }
    }
}
