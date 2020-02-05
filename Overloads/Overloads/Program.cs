using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloads
{
    class Program
    {
        static void Main(string[] args)
        {
            Mathclass math = new Mathclass();
            
            mathClass(5.8f, 5.9f);
            mathClass(5, 6);

            Console.ReadLine();
            
        }
        public static void mathClass(float n1, float n2)
        {
            float f = 0;
            f = n1 + n2;
            Console.WriteLine(f);
        }
        public static void mathClass(int i1, int i2)
        {
            int i = 0;
            i = i1 + i2; 

        }

        public class Mathclass
        {
            // plus
            public int add(int i1 , int i2)
            {
                return i1 + i2; 
            }
            public float add(float f1, float f2)
            {
                return f1 + f2;
            }
            public string add(string s1 , string s2)
            {
                
                int i = int.Parse(s1); 
                int ii = int.Parse(s2);
                int iii = i + ii; 
                
                return iii.ToString(); 
            }
            //minus
            public int minus(int i1, int i2)
            {
                return i1 - i2;
            }
            public float minus(float f1, float f2)
            {
                return f1 - f2;
            }
            public string minus(string s1, string s2)
            {
                int i = int.Parse(s1);
                int ii = int.Parse(s2);
                int iii = i - ii;
                return iii.ToString();
            }
            //gange
            public int multiply(int i1, int i2)
            {
                return i1 * i2;
            }
            public float multiply(float f1, float f2)
            {
                return f1 * f2;
            }
            public string multiply(string s1, string s2)
            {
                int i = int.Parse(s1);
                int ii = int.Parse(s2);
                int iii = i * ii;
                return iii.ToString();
            }
            //divide
            public int divide(int i1, int i2)
            {
                return i1 / i2;
            }
            public float divide(float f1, float f2)
            {
                return f1 / f2;
            }
            public string devide(string s1, string s2)
            {
                int i = int.Parse(s1);
                int ii = int.Parse(s2);
                int iii = i / ii;
                return iii.ToString();
            }

        }
        
    }
}
