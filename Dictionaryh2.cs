using System;
using System.Collections.Generic;

namespace DIctionariesh2
{
    class Program
    {
        private static Dictionary<string, object> dict;

        static void Main(string[] args)
        {
            dict = new Dictionary<string, object>();

            // all int data with string key
            Add("Hans", 32);
            Add("Michael", 31);
            Add("Mads", 28);
            Add("Jannick", 45);
            Add("Benjamin", 86);
            Add("Sonni", 1100);
            Add("Simon", 85);
            Add("Sacha", 72);
            Add("Brian", 61);
            Add("Nigel", 1200000);

            Dictionary<string, object>.ValueCollection valueOfAge = dict.Values;
            Dictionary<string, object>.KeyCollection keyOfName = dict.Keys;


            foreach (var item in dict )
            {
                Console.WriteLine("Key:" + item.Key + "value:" + item.Value);
                

            }
            Console.ReadLine();


        }

        private static void Add(string strkey, object datatype)
        {
            if (!dict.ContainsKey(strkey))
            {
                dict.Add(strkey, datatype);
            }
            else
            {
                dict[strkey] = datatype;
            }
        }
        private static T GetAnyValue<T>(string strkey)
        {
            object obj;
            T retType;

            dict.TryGetValue(strkey, out obj);

            try
            {
                retType = (T)obj;

            }
            catch
            {
                retType = default(T);

            }
            return retType;
        }

    }
}