using System;

namespace CF1092B_Teams_Forming
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));

            Array.Sort(a);
            int change = 0;

            for(int j = 0; j < a.Length; j += 2)
            {
                change += a[j + 1] - a[j];
            }

            Console.WriteLine(change);
        }
    }
}
