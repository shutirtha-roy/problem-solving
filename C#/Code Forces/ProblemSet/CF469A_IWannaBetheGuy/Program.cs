using System;
using System.Collections.Generic;
using System.Linq;

namespace CF469A_IWannaBetheGuy
{
    public class Program
    {
        static void Main(string[] args)
        {
            string value;
            while(!string.IsNullOrEmpty(value = Console.ReadLine()))
            {
                int level = int.Parse(value);

                string[] pValue = Console.ReadLine().Split(' ');
                string[] qValue = Console.ReadLine().Split(' ');
                string[] xValues;
                string[] yValues;


                if (pValue.Length > 1)
                {
                    xValues = pValue.Skip(1).ToArray();
                }
                else
                {
                    xValues = pValue;
                }

                if (pValue.Length > 1)
                {
                    yValues = qValue.Skip(1).ToArray();
                }
                else
                {
                    yValues = qValue;
                }

                

                int[] xInt = Array.ConvertAll(xValues, int.Parse);
                int[] yInt = Array.ConvertAll(yValues, int.Parse);
                int[] combined = xInt.Union(yInt).ToArray();

                Array.Sort(combined);

                int maxValue = combined.Max();



                if(maxValue < level || combined.Length < level)
                {
                    Console.WriteLine("Oh, my keyboard!");
                }
                else
                {
                    Console.WriteLine("I become the guy.");
                }
              


            }
        }
    }
}
