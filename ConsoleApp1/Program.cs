using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int myNum;
            int theirNum;
            string userInput;
            myNum = new Random().Next(0, 100);
            int rNum = myNum;
            Console.WriteLine(rNum);
            Console.WriteLine("Hello World");
            Console.WriteLine("I am thinking of a number between 0 and 100");
            Console.WriteLine("What your guess?");
            userInput = Console.ReadLine();
            theirNum = Convert.ToInt32(userInput);
            while (theirNum != myNum)
            {
                if (theirNum > myNum)
                {
                    Console.WriteLine(theirNum + "is higher than my number");
                    Console.WriteLine("What your new guess?");
                    userInput = Console.ReadLine();
                    theirNum = Convert.ToInt32(userInput);
                }
                else if (theirNum < myNum)
                {
                    Console.WriteLine( theirNum + " is lower than my number");
                    Console.WriteLine("What your new guess?");
                    userInput = Console.ReadLine();
                    theirNum = Convert.ToInt32(userInput);
                }
                
            }
            Console.WriteLine("YOU HAVE GUESSED THE CORRECT NUMBER!");
            Console.WriteLine("My number was: " + myNum);
            Console.ReadKey();
        }
    }
}
