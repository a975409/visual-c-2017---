using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;

namespace 實例195
{
    class Program
    {
        static void Main(string[] args)
        {
            IReadOnlyDictionary<string, string> rdic = GetReadOnly();

            foreach(var key in rdic.Keys)
            {
                Console.WriteLine("{0} - {1}",key,rdic[key]);
            }

            
        }

        static IReadOnlyDictionary<string,string> GetReadOnly()
        {
            IDictionary<string, string> d = new Dictionary<string, string>();
            d["city"] = "Guang Zhou";
            d["Name"] = "Mr Liu";
            d["subject"] = "ASP.Net Core";

            return d.ToReadOnlyDictionary();
        }
    }

    public static class DictionaryExtensions
    {
        public static IReadOnlyDictionary<TKey, TValue> ToReadOnlyDictionary<TKey, TValue>(this IDictionary<TKey, TValue> srcDictionary)
        {
            return new ReadOnlyDictionary<TKey, TValue>(srcDictionary);
        }
    }
}
