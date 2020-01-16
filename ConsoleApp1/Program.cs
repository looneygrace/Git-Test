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
            int myNum, begin, end;
            int theirNum;
            string userInput;
            
            Console.WriteLine("Hello World");


            //determining range
            Console.WriteLine("What's the range of the guessing? [x,y]");
            Console.Write("x?");
            userInput = Console.ReadLine();
            begin = Convert.ToInt32(userInput);
            Console.Write("y?");
            userInput = Console.ReadLine();
            end = Convert.ToInt32(userInput);

            //thinking of Number
            myNum = new Random().Next(begin, end);
            int rNum = myNum;
            Console.WriteLine(rNum);

            Console.WriteLine(userInput);
            Console.WriteLine("I am thinking of a number between " + begin + "and" + end);

            Console.WriteLine("What is your guess?");
            userInput = Console.ReadLine();
            theirNum = Convert.ToInt32(userInput);
            while (theirNum != myNum)
            {
                if (theirNum > myNum)
                {
                    Console.WriteLine(theirNum + "is higher than my number");
                    Console.WriteLine("What is your new guess?");
                    userInput = Console.ReadLine();
                    theirNum = Convert.ToInt32(userInput);
                }
                else if (theirNum < myNum)
                {
                    Console.WriteLine( theirNum + " is lower than my number");
                    Console.WriteLine("What is your new guess?");
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
