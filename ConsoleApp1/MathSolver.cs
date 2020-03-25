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

        public static void Swap(ref double[] array, int first, int second)
        {
            double temp = array[first];
            array[first] = array[second];
            array[second] = temp;
        }

        public static double CountField(int number, double[,] points)
        {
            //MINIMAL AND MAXIMUM COORDINATES AMONG ALL POINTS
            double minX = 0;
            double maxX = 0;

            double minY = 0;
            double maxY = 0;

            for (int i = 0; i < points.GetLength(0); i++)
            {
                if (points[i, 0] < minX)
                    minX = points[i, 0];
                if (points[i, 1] < minY)
                    minY = points[i, 1];
            }
            for (int i = 0; i < points.GetLength(0); i++)
            {
                if (points[i, 0] > maxY)
                    maxX = points[i, 0];
                if (points[i, 1] > maxY)
                    maxY = points[i, 1];
            }

            //CENTER POINT
            double[] center = new double[2];
            center[0] = (maxX - minX) / 2;
            center[1] = (maxY - minY) / 2;

            //ARCTAN()
            double[] angles = new double[number];

            for (int i = 0; i < points.GetLength(0); i++)   //0 0 0 2 2 2 2 0 SPECIFIC DATA WHERE THE FIRST IN NaN THE SECOND IS OVERFLOW
            {
                //if(points)	//is equal (0,0)
                angles[i] = Math.Atan((points[i, 1]) / (points[i, 0])); //from center point

                if (points[i, 0] > 0 && points[i, 1] > 0)   //FOR A POINT
                {
                    angles[i] *= 180 / Math.PI;
                }
                if (points[i, 0] < 0 && points[i, 1] > 0)   //FOR B POINT
                {
                    angles[i] += Math.PI;
                    angles[i] *= 180 / Math.PI;
                }
                if (points[i, 0] < 0 && points[i, 1] < 0)   //FOR C POINT
                {
                    angles[i] += Math.PI;
                    angles[i] *= 180 / Math.PI;
                }
                if (points[i, 0] > 0 && points[i, 1] < 0)   //FOR D POINT
                {
                    angles[i] += 2 * Math.PI;
                    angles[i] *= 180 / Math.PI;
                }
            }

            //PRINT ANGLES
            //for (int i = 0; i < angles.Length; i++)
            //{
            //    Console.WriteLine(angles[i]);
            //}

            //SORT BOTH ARRAYS
            double temporary = 0;
            for (int i = 0; i < angles.Length; i++)
            {
                bool isAnyChange = false;
                for (int j = 0; j < angles.Length - 1; j++)
                {
                    if (angles[j].CompareTo(angles[j + 1]) > 0)
                    {
                        isAnyChange = true;
                        MathSolver.Swap(ref angles, j, j + 1);

                        temporary = points[j, 0];
                        points[j, 0] = points[j + 1, 0];
                        points[j + 1, 0] = temporary;

                        temporary = points[j, 1];
                        points[j, 1] = points[j + 1, 1];
                        points[j + 1, 1] = temporary;
                    }
                    if (!isAnyChange)    //IF IN THE SERIES THERE WAS NOT A CHANGE THEN ARRAY IS SORTED SO BREAK ANY COMPARISIONS
                    {
                        break;
                    }
                }
            }

            //CALCULATE FIELD OF TRIANGLES
            double[] fields = new double[number];
            for (int i = 0; i < fields.Length; i++)
            {
                if (i < (fields.Length - 1))
                {
                    fields[i] = 0.5 * Math.Abs((center[0] - points[i, 0]) * (points[i + 1, 1] - points[i, 1]) - (center[1] - points[i, 1]) * (points[i + 1, 0] - points[i, 0]));    //overflow i=4
                }
                else
                {
                    fields[i] = 0.5 * Math.Abs((center[0] - points[i, 0]) * (points[0, 1] - points[i, 1]) - (center[1] - points[i, 1]) * (points[0, 0] - points[i, 0]));    //change i+1 to 0 because of overflow
                }
            }

            //CALCULATE FIELD OF WHOLE SHAPE
            double wholeField = 0;
            for (int i = 0; i < points.GetLength(0); i++)
            {
                wholeField += fields[i];
            }

            return wholeField;
        }
    }
}
