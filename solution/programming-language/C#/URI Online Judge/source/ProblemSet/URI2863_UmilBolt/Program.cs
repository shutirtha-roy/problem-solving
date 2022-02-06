using System;
using System.Collections;


namespace URI2863_UmilBolt
{
    class Program
    {
        static void Main(string[] args)
        {
            string T;
            double Ti, minimum;
            double[] newArray;

            while (!string.IsNullOrEmpty(T = Console.ReadLine()))
            {
                newArray = new double[int.Parse(T)];
                for (var i = 0; i < newArray.Length; i++)
                {
                    Ti = double.Parse(Console.ReadLine());
                    newArray[i] = Ti;
                }
                minimum = min(newArray);
                Console.WriteLine(minimum);
            }
        }

        static double min(double[] newArray)
        {
            var firstValue = newArray[0];
            double minValue = newArray[0];
            
            for (var i = 0; i < newArray.Length; i++)
            {
                if (firstValue > newArray[i])
                {
                    minValue = newArray[i];
                }
            }
            return minValue;
        }
    }
}
