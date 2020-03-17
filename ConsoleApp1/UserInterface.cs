using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public static class UserInterface
    {
        public static void ChoseOption(int option)
        {
            switch(option)  //readkey does not work for 10th option
            {
                case 49:
                    Console.WriteLine("\nFind Min Value from sequence: ");
                    var values1 = Sequence.Read();
                    Console.WriteLine(MathSolver.Min(values1));

                    Console.ReadKey();
                    break;

                case 50:
                    Console.WriteLine("\nSort in descending the following sequence: ");
                    var values2 = Sequence.Read();
                    MathSolver.Sort(values2);
                    Console.WriteLine(string.Join(", ", values2));

                    Console.ReadKey();
                    break;

                case 51:
                    Console.WriteLine("\nShypotenuse length from 2D vector: ");
                    var values3 = Sequence.Read();
                    Console.WriteLine(MathSolver.Hypotenus(values3));

                    Console.ReadKey();
                    break;

                case 52:
                    Console.WriteLine("\nStandard deviation for the following sequence: ");
                    var values4 = Sequence.Read();
                    Console.WriteLine(MathSolver.StandardDeviation(values4));

                    Console.ReadKey();
                    break;

                case 53:
                    Console.WriteLine("\nRevert the following sequence: ");
                    var values5 = Sequence.Read();
                    MathSolver.Reverse(values5);
                    Console.WriteLine(string.Join(", ", values5));

                    Console.ReadKey();
                    break;

                case 54:
                    Console.WriteLine("\nCheck if the number is prime: ");
                    var values6 = Sequence.Read();
                    Console.WriteLine(MathSolver.IsPrime(values6));

                    Console.ReadKey();
                    break;

                case 55:    //field
                    Console.WriteLine("\nField of convex polygon from vectors: ");
                    var values7 = Sequence.Read();

                    Console.ReadKey();
                    break;

                case 56:    //n^2 and n^3 equations
                    Console.WriteLine("\nSolve third degree equation: ");
                    var values8 = Sequence.Read();

                    Console.ReadKey();
                    break;

                case 57:
                    Console.WriteLine("\nResult of 1*2^2 + 2*3^2 + 3*4^2 + ... + n(n+1)^2 for the particular n: ");
                    var values9 = Sequence.Read();
                    Console.WriteLine(MathSolver.Equation(values9));

                    Console.ReadKey();
                    break;

                case 58:
                    Console.WriteLine("\nNumber of set bits in the particular number: ");
                    var values10 = Sequence.Read();
                    Console.WriteLine(MathSolver.SetBits(values10));

                    Console.ReadKey();
                    break;

                default:
                    Console.WriteLine("There is no option like this.");
                    break;
            }
        }
    }
}
