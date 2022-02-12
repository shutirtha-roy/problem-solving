using System;

namespace CF451A_GameWithSticks
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
                int m = integerValues[1];

                if(n >= m)
                {
                    if(m % 2 == 0)
                    {
                        Console.WriteLine("Malvika");
                    }
                    else
                    {
                        Console.WriteLine("Akshat");
                    }
                }
                else
                {
                    if (n % 2 == 0)
                    {
                        Console.WriteLine("Malvika");
                    }
                    else
                    {
                        Console.WriteLine("Akshat");
                    }
                }
            }
        }
    }
}
