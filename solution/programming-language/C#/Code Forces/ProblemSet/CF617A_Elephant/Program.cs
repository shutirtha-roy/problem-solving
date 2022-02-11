using System;

namespace CF617A_Elephant
{
    class Program
    {
        static void Main(string[] args)
        {
            string value;
            while (!string.IsNullOrEmpty(value = Console.ReadLine()))
            {
                int x = int.Parse(value);
                int positions = 5;
                int minSteps = 0;


                while(positions >= 1)
                {
                    minSteps += x / positions;
                    x = x % positions;

                    if (x == 0)
                    {
                        break;
                    }

                    positions--;
                }

                Console.WriteLine(minSteps);
            }
        }
    }
}
