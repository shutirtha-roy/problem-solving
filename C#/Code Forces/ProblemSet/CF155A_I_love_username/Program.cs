using System;

namespace CF155A_I_love_username
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string pointsString = Console.ReadLine();
            int[] performances;

            if (pointsString.Contains(' '))
            {
                performances = Array.ConvertAll(pointsString.Split(' '), s => int.Parse(s));
                int maxValue = Math.Max(performances[0], performances[1]), minValue = Math.Min(performances[0], performances[1]), count;

                if (maxValue != minValue)
                    count = 1;
                else
                    count = 0;

                for (int i = 1; i < n - 1; i++)
                {
                    if (performances[i + 1] > maxValue || performances[i + 1] < minValue)
                        count++;

                    maxValue = Math.Max(maxValue, performances[i + 1]);
                    minValue = Math.Min(minValue, performances[i + 1]);

                }

                Console.WriteLine(count);
            }
            else
                Console.WriteLine(0);
                
            
        }
    }
}
