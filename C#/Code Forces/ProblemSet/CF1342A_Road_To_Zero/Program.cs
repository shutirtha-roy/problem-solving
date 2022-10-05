using System;

namespace CF1342A_Road_To_Zero
{
    class Program
    {
        static void Main(string[] args)
        {
            long t = int.Parse(Console.ReadLine());

            for(int i = 1; i <= t; i++)
            {
                long[] xy = Array.ConvertAll(Console.ReadLine().Split(' '), s => long.Parse(s));
                long x = xy[0], y = xy[1];
                long[] ab = Array.ConvertAll(Console.ReadLine().Split(' '), s => long.Parse(s));
                long a = ab[0], b = ab[1];

                long maxValue = Math.Max(x, y), minValue = Math.Min(x, y);
                long total = 0;

                if(a * 2 >= b)
                {
                    total += b * minValue;
                    maxValue -= minValue;
                    minValue = 0;
                    total += maxValue * a;
                }
                else
                {
                    total += minValue * a + maxValue * a;
                }

                Console.WriteLine(total);
            }
        }
    }
}
