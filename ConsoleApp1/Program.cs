using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("---------- MathSolver ----------");
            Console.Write("Chose one of 10 options: ");
            var option = Console.ReadKey();

            UserInterface.ChoseOption(option);
        }
    }
}
