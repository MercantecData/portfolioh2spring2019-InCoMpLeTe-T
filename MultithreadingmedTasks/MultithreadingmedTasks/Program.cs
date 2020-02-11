using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MultithreadingmedTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter counter = new Counter();
            int min = 1;
            int max = 10;
            int TheNumber = counter.GetRandomNumber(min, max);
            
            counter.Intro();// starter intro()
            
            counter.GetRandomNumber(min, max); // et randome nummer hver gang
            Task.Run(counter.countFrom10);//starte countdown
                                          

             
            counter.RightOrNot(TheNumber); //sender tallet der skal gættes. 
            
            //Console.WriteLine(TheNumber + "den her?");
            Console.ReadLine();
            
        }
        


    }
    public class Counter
    {
        bool b = true;
        public void Intro()
        {
            Console.WriteLine("Welcome to the game");
            Console.WriteLine("You now have 10 sec to guess a number");
            Console.WriteLine("within 1 - 10 ");
            Console.WriteLine("Hit Enter if you are Ready!");
            Console.ReadKey();
            Console.WriteLine("Game will start in:");
            
            int i = 3;
            while (i>0)
            {
                Thread.Sleep(1000);
                Console.WriteLine(i);

                i = i - 1 ; 
            }
            Console.WriteLine("start:");
            Console.WriteLine("guess your number");

        }
        public async Task countFrom10()
        {

            int i = 10;

                while (i >= 0 && b == true)
                {
                    await Task.Delay(1000);

                    Console.WriteLine("you have: {0} left", i);
                    i = i - 1;

                }
            
            
            
            
        }
        private static readonly Random getrandom = new Random();

        public int GetRandomNumber(int min, int max)
        {
            lock (getrandom) 

            {
                return getrandom.Next(min, max);
            }
        }
        
        public void RightOrNot(int theNumber)
        {
            int i = 0;
            int userGuess =0; 
            while (userGuess != theNumber)
	        {
                
                userGuess = int.Parse(Console.ReadLine());

                if (userGuess == theNumber)
                {
                    Console.Clear();
                    Console.WriteLine("omg you win! {0} was the right number", theNumber);
                    b = false; 
                }
                else
                {
                Console.WriteLine("nope!");
                }
                
	        }
        }
       
    }

}
