using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace
namespace LearnDotNet
{
    //Main Class
    class Program
    {

        

        //Entry Point Method
        static void Main(string[] args)
        {
            string name = "Jake Horner";
            int age = 23;

            VarMessing(name, age);
            Simple(name);
            NumberGame();
        }

        private static void VarMessing(string name, int age) {

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.Red;

            Console.WriteLine("Hello .Net Framework");

            Console.ResetColor();

            Console.WriteLine("{0} is {1}", name, age);
        }

        private static void Simple(string name) {
            Console.WriteLine("What is your name?");
            string input = Console.ReadLine();
            Console.WriteLine("Hello {0}, Wecome to {1}s .Net Framework Practice", input, name);
        }

        private static void NumberGame() {
            Random rnd = new Random();
            int correctNumber = rnd.Next(1, 10);
            int guess = 0;
            Console.WriteLine("Guess a number between 1 and 10");
            string input = Console.ReadLine();

            try
            {
                guess = Int32.Parse(input);
            }
            catch (Exception e)
            {
                Console.WriteLine("Please Enter a Number");
            }
            

            if (guess == correctNumber)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("YOU WON!");
            }
            else {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("YOU GUESSED {0}, THE CORRECT ANSER WAS {1}",guess,correctNumber);
                Console.ResetColor();
                Console.WriteLine("Try Again...");
                NumberGame();
            }
        }
    }
}
