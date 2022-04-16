using System;
using System.Linq;

namespace CF510A_FoxAndSnake
{
    class Program
    {
        static void Main(string[] args)
        {
            string value;
            while (!string.IsNullOrEmpty(value = Console.ReadLine()))
            {
                int n = Array.ConvertAll(value.Split(' '), s => int.Parse(s))[0];
                int m = Array.ConvertAll(value.Split(' '), s => int.Parse(s))[1];

                string stringOne = FullPattern(m);
                string stringTwo = CenterPattern(m);
                string reverseString = new string(stringTwo.ToCharArray().Reverse().ToArray());

                int count = 0;
                for(var i = 0; i < n - 1; i+=2)
                {
                    Console.WriteLine(stringOne);

                    if(count % 2 == 0)
                    {
                        Console.WriteLine(stringTwo);
                    }
                    else
                    {
                        Console.WriteLine(reverseString);
                    }

                    count++;
                }
                Console.WriteLine(stringOne);

            }
        }

        static string FullPattern(int m, string symbol = "#")
        {
            string patternString = "";

            for(var i = 0; i < m; i++)
            {
                patternString += symbol;
            }

            return patternString;
        }

        static string CenterPattern(int m)
        {
            string beforeStringPattern = FullPattern(m - 1, ".");
            beforeStringPattern += "#";
            return beforeStringPattern;
        }
    }
}
