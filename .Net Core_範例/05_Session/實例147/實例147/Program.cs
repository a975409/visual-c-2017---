using System;
using System.Globalization;

namespace 實例147
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal val = 3960.12M;
            CultureInfo cn = CultureInfo.GetCultureInfoByIetfLanguageTag("zh-cn");
            CultureInfo tw = CultureInfo.GetCultureInfoByIetfLanguageTag("zh-TW");
            CultureInfo us = CultureInfo.GetCultureInfoByIetfLanguageTag("en-US");
            CultureInfo mo = CultureInfo.GetCultureInfoByIetfLanguageTag("zh-MO");
            CultureInfo hk = CultureInfo.GetCultureInfoByIetfLanguageTag("zh-HK");
            CultureInfo jp = CultureInfo.GetCultureInfoByIetfLanguageTag("ja-JP");

            Console.WriteLine("原數值：{0}\n", val);

            Console.WriteLine("人民幣：{0}\n", val.ToString("C", cn));
            Console.WriteLine("新台幣：{0}\n", val.ToString("C", tw));
            Console.WriteLine("美金：{0}\n", val.ToString("C", us));
            Console.WriteLine("澳元：{0}\n", val.ToString("C", mo));
            Console.WriteLine("港幣：{0}\n", val.ToString("C", hk));
            Console.WriteLine("日元：{0}\n", val.ToString("C", jp));

            Console.ReadKey();
        }
    }
}
