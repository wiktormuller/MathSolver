﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public static class UserInterface
    {
        public static void ChoseOption(int option)
        {
            switch(option)
            {
                case 1:
                    Console.WriteLine("\nFind Min Value from sequence: ");
                    var values1 = Sequence.Read();
                    Console.WriteLine(MathSolver.Min(values1));

                    Console.ReadKey();
                    break;

                case 2:
                    Console.WriteLine("\nSort in descending the following sequence: ");
                    var values2 = Sequence.Read();
                    MathSolver.Sort(values2);
                    Console.WriteLine(string.Join(", ", values2));

                    Console.ReadKey();
                    break;

                case 3:
                    Console.WriteLine("\nShypotenuse length from 2D vector: ");
                    var values3 = Sequence.Read();
                    Console.WriteLine(MathSolver.Hypotenus(values3));

                    Console.ReadKey();
                    break;

                case 4:
                    Console.WriteLine("\nStandard deviation for the following sequence: ");
                    var values4 = Sequence.Read();
                    Console.WriteLine(MathSolver.StandardDeviation(values4));

                    Console.ReadKey();
                    break;

                case 5:
                    Console.WriteLine("\nRevert the following sequence: ");
                    var values5 = Sequence.Read();
                    MathSolver.Reverse(values5);
                    Console.WriteLine(string.Join(", ", values5));

                    Console.ReadKey();
                    break;

                case 6:
                    Console.WriteLine("\nCheck if the number is prime: ");
                    var values6 = Sequence.Read();
                    Console.WriteLine(MathSolver.IsPrime(values6));

                    Console.ReadKey();
                    break;

                case 7:
                    Console.WriteLine("\nField of convex polygon from vectors: ");

                    //HOW MANY POINTS WILL BE TYPED
                    Console.WriteLine("How many point: ");
                    int number = Int32.Parse(Console.ReadLine());

                    double[,] points = new double[number, 2];
                    for (int i = 0; i < points.GetLength(0); i++)
                    {
                        Console.Write("Point " + i + " coordinate x: ");
                        points[i, 0] = Int32.Parse(Console.ReadLine());
                        Console.Write("Point " + i + " coordinate y: ");
                        points[i, 1] = Int32.Parse(Console.ReadLine());
                    }

                    var field = MathSolver.CountField(number, points);
                    Console.WriteLine("The whole field of that shape is: " + field);

                    Console.ReadKey();
                    break;

                case 8: //n^2 and n^3 equations
                    Console.WriteLine("\nSolve quadratic equation: ");
                    var values8 = Sequence.Read();
                    MathSolver.QuadraticEquation(values8);

                    Console.ReadKey();
                    break;

                case 9:
                    Console.WriteLine("\nResult of 1*2^2 + 2*3^2 + 3*4^2 + ... + n(n+1)^2 for the particular n: ");
                    var values9 = Sequence.Read();
                    Console.WriteLine(MathSolver.Equation(values9));

                    Console.ReadKey();
                    break;

                case 10:
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
