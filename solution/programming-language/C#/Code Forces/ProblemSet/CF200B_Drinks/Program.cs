using System;

namespace CF200B_Drinks
{
    class Program
    {
        static void Main(string[] args)
        {
            string value;
            while (!string.IsNullOrEmpty(value = Console.ReadLine()))
            {
                int n = int.Parse(value);
                string[] fractionString = Console.ReadLine().Split(' ');

                int[] fraction = Array.ConvertAll(fractionString, s => int.Parse(s));

                double ratio = 0;

                foreach(var individualFraction in fraction)
                {
                    ratio += individualFraction;
                }

                ratio /= fraction.Length;

                Console.WriteLine(String.Format("{0:F12}", ratio));
            }
        }
    }
}
