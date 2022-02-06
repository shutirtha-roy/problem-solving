using System;

namespace CF1030A_InSearchofanEasyProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            string value;
            while (!string.IsNullOrEmpty(value = Console.ReadLine()))
            {
                var n = int.Parse(value);
                string difficulty = Console.ReadLine();

                if (difficulty.Contains('1'))
                {
                    Console.WriteLine("HARD");
                }
                else
                {
                    Console.WriteLine("EASY");
                }

                
            }
        }
    }
}
