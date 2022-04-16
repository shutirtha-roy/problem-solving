using System;

namespace CF750A_NewYearandHurry
{
    class Program
    {
        static void Main(string[] args)
        {
            string value;
            while (!string.IsNullOrEmpty(value = Console.ReadLine()))
            {
                int[] integerValues = Array.ConvertAll(value.Split(' '), s => int.Parse(s));
                int n = integerValues[0];
                int k = integerValues[1];
                int minutesLeft = 240;
                minutesLeft -= k;

                while (n >= 1)
                {
                    int problemTime = ProblemTime(n);

                    if(minutesLeft - problemTime >= 0)
                    {
                        break;
                    }

                    n--;
                }

                Console.WriteLine(n);
            }
        }

        static int ProblemTime(int n)
        {
            int totalTime = 0;

            for(var i = 1; i <= n; i++)
            {
                totalTime += (5 * i);
            }

            return totalTime;
        }
    }
}
