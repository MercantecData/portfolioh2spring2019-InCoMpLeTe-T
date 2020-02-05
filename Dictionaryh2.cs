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

            foreach (object alder in valueOfAge) 
            {
                Console.WriteLine("{0} er Gammel", alder);
            }
            /*foreach (string navn in keyOfName )
            {
                foreach (object alder in valueOfAge) // den køre færdig før navn  skifter
                {
                    Console.WriteLine("{0} er {1} Gammel", navn, alder);
                }

            }*/

            int i = 0;
            int ii = 0;
            while (i < keyOfName.Count)
            {
                while (ii < valueOfAge.Count)
                {
                    Console.WriteLine("{0} er {1} Gammel", keyOfName, valueOfAge);
                    ii = ii + 1;
                }
                i = i + 1;
            }
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