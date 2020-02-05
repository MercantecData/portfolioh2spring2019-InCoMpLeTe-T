using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    class Program
    {
        public delegate int multiNumbers(int i);
        public delegate float plusNumbers(float f1, float f2, float f3);
        public delegate string Hello();

        static void Main(string[] args)
        {
        
            multiNumbers Le1 = gange => gange * 2;
            plusNumbers p1 = (f1, f2, f3) => f1 + f2 + f3;
            Hello h1 = () => "Hello world";  
            Console.WriteLine(h1());
            Console.WriteLine(p1(5.76f, 5.98f, 98.21f));
            Console.WriteLine(Le1(5));

            Console.WriteLine();

        }
    }
}
