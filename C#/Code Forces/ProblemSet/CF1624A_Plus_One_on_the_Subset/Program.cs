using System;
using System.Linq;

namespace CF1624A_Plus_One_on_the_Subset
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            for(int i = 0; i < t; i++)
            {
                int n = int.Parse(Console.ReadLine());
                int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));
                int maxValue = a.Max();
                int minValue = a.Min();
                Console.WriteLine(maxValue - minValue);
            }
        }
    }
}
