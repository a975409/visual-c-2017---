using System;

namespace 實例122
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Today;

            var weekday = today.DayOfWeek;

            string msg = "今天是";

            switch(weekday)
            {
                case DayOfWeek.Sunday:
                    msg += "星期日";
                    break;

                case DayOfWeek.Monday:
                    msg += "星期一";
                    break;
                case DayOfWeek.Tuesday:
                    msg += "星期二";
                    break;
                case DayOfWeek.Wednesday:
                    msg += "星期三";
                    break;
                case DayOfWeek.Thursday:
                    msg += "星期四";
                    break;
                case DayOfWeek.Friday:
                    msg += "星期五";
                    break;
                case DayOfWeek.Saturday:
                    msg += "星期六";
                    break;
            }

            Console.WriteLine(msg);
            Console.ReadKey();
        }
    }
}
