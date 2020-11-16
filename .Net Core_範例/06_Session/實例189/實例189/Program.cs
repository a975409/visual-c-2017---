using System;

namespace 實例189
{
    class Program
    {
        static void Main(string[] args)
        {
            MySample sa = new MySample();

            sa[0] = 209;
            sa[1] = 39;
            sa[5] = 122;
            sa[9] = 60;

            sa.PrintAll();
        }
    }

    public class MySample
    {
        private byte[] _data = new byte[10];

        public byte this[int index]
        {
            get
            {
                if (index < 0 || index >= _data.Length)
                    return 0;

                return _data[index];
            }

            set
            {
                if (index >= 0 || index < _data.Length)
                    _data[index] = value;

            }
        }

        public void PrintAll()
        {
            string msg = string.Join("、", _data);
            Console.WriteLine($"元素清單：\n{msg}\n\n");
        }

    }
}
