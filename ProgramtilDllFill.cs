using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Librarydll;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 5, 6, 7, 4, 3, 7, 8, 9 };
            Librarydll.Class1 piss = new Librarydll.Class1();
            int[] letsgo = piss.sortet(numbers);
            int i = 0; 
            while (i < letsgo.Length)
            {
                Console.WriteLine(letsgo[i]);
                i = i + 1; 
            }
            Console.ReadLine();
        }
        
    
   
    }
}
