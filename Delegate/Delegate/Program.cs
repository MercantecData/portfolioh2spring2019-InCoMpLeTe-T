using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Program
    {
       
        static void Main(string[] args)
        {
            deleGate3 ddd = d3;
            ddd("hej", "med" , "dig");
            delegate1 dd = d1;
            dd(); 
            deleGate2 d2 = f1;
            Console.WriteLine(d2());
            Console.ReadLine();
            
        }

        public delegate void delegate1();
        public delegate float deleGate2();
        public delegate void deleGate3(string s1, string s2, string s3);//int i1, int i2, int i3
        public static float f1()
        {
            return 10f;
        }
        public static void d1()
        {
            Console.WriteLine(" Hello world");
        }
        public static void d3(string s1, string s2, string s3)
        {

            string s4 = s1 + " " + s2 + " " + s3;
            Console.WriteLine(s4);
           
        }

    }
}
