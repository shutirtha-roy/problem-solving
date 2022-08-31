using System;

namespace CF598A_Tricky_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            long t = long.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                long n = long.Parse(Console.ReadLine());
                long sum = n * (n + 1) / 2;
                long negation = 0;

                for (long j = 1; j <= n; j *= 2)
                {
                    sum -= 2 * j;
                }

                Console.WriteLine(sum);
            }
        }
    }
}
