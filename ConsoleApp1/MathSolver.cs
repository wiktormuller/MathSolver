using System;
using System.Linq;

namespace ConsoleApp1
{
    public static class MathSolver
    {
        public static double Min(double[] values)
        {
            return values.Min();    //without linq?
        }

        public static void Sort(in double[] values)
        {
            Array.Sort(values); //implement sort algorithm
        }

        public static double Hypotenus(double[] values)
        {
            return Math.Sqrt(values[0] * values[0] + values[1] * values[1]);
        }

        public static double Sum(double[] values)
        {
            double sum = 0;
            for(int i=0; i < values.Length; i++)
            {
                sum += values[i];
            }
            return sum;
        }

        public static double SumOfSquares(double[] values)
        {
            double sum = 0;
            for (int i = 0; i < values.Length; i++)
            {
                sum += (values[i] * values[i]);
            }
            return sum;
        }

        public static double Average(double[] values)
        {
            double sum = Sum(values);
            double average = sum / values.Length;

            return average;
        }

        public static double Variance(double [] values)
        {
            double average = Average(values);
            double sumOfSquares = SumOfSquares(values);
            double variance = ((sumOfSquares / values.Length) - (average * average));

            return variance;
        }

        public static double StandardDeviation(double[] values)
        {
            double variance = Variance(values);
            double standardDeviation = Math.Sqrt(variance);

            return standardDeviation;
        }

        public static void Reverse(in double[] values)
        {
            Array.Reverse(values);  //own implementation?
        }

        public static string IsPrime(double[] values)   //we dont want here a array but single variable
        {
            if(values[0] <= 1)
            {
                return "It's not a prime number.";
            }

            for(int i=2; (i*i)<values[0]; i++)
            {
                if(values[0]%2 == 0)
                {
                    return "It's not a prime number.";
                }
            }
            return "It is a prime number.";
        }

        public static double Equation(double[] values)
        {
            double result = (values[0] * (values[0] + 1) * (values[0] + 2) * (3 * values[0] + 5))/12;

            return result;
        }

        public static int SetBits(double[] values)
        {
            int[] newValues = Array.ConvertAll<double, int>(values, Convert.ToInt32);

            int numberOfSetBits = 0;
            while (newValues[0] > 0)
            {
                numberOfSetBits += newValues[0] & 1;    //why?  //if the rightmost bit has 1, increment the counter
                newValues[0] >>= 1;
            }

            return numberOfSetBits;
        }
    }
}
