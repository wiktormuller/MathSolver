using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public static class Sequence
    {
        public static double[] Read()
        {
            string line = Console.ReadLine();
            string[] split = line.Split(new Char[] {' ', ':', '\t'});
 
            double[] values = Array.ConvertAll(split, new Converter<string, double>(Double.Parse)); //it is error prone

            return values;
        }
    }
}
