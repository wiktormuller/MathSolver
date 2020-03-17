using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------- MathSolver ----------");
            Console.Write("Chose one of 10 options: ");
            var option = Console.ReadKey();

            UserInterface.ChoseOption((int)option.Key);
        }
    }
}
