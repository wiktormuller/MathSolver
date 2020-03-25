using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------- MathSolver ----------");
            
            while(true)
            {
                Console.Write("\nChose one of 10 options: ");
                string input = Console.ReadLine();

                try
                {
                    int option = Int32.Parse(input);
                    UserInterface.ChoseOption(option);
                }
                catch (FormatException)
                {
                    Console.WriteLine("It is not digit.");
                }
            }
        }
    }
}
