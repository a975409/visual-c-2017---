using System;
using System.Globalization;

namespace 實例123
{
    class Program
    {
        static void Main(string[] args)
        {
            ChineseLunisolarCalendar cncld = new ChineseLunisolarCalendar();

            DateTime d1 = new DateTime(2020, 10, 5);

            Console.WriteLine($"{d1.ToString("yyyy/MM/dd")}，農曆：{cncld.GetMonth(d1)}月{cncld.GetDayOfMonth(d1)}日");
            Console.ReadKey();
        }
    }
}
