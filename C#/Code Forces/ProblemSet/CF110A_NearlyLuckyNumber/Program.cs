using System;

namespace CF110A_NearlyLuckyNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string value;
            while (!string.IsNullOrEmpty(value = Console.ReadLine()))
            {
                int countLucky = 0;
                int countUnlucky = 0;

                foreach(char digits in value)
                {
                    int digit = int.Parse(Convert.ToString(digits));

                    if (digit == 4 || digit == 7)
                    {
                        countLucky++;
                    }
                    else
                    {
                        countUnlucky++;
                    }
                }

                Console.WriteLine(checker(countUnlucky, countLucky));
            }
        }

        static string checker(int countUnlucky, int countLucky)
        {
            if (countLucky == 4 || countLucky == 7)
            {
                return "YES";
            }
            else
            {
                return "NO";
            }
        }
    }
}
