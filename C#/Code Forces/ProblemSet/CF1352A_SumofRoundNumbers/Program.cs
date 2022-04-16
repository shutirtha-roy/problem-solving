using System;
using System.Collections.Generic;

namespace CF1352A_SumofRoundNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string value;
            while (!string.IsNullOrEmpty(value = Console.ReadLine()))
            {
                int t = int.Parse(value);
                List<int> rounds = new List<int>();
                int round;

                for(var i = 0; i < t; i++)
                {
                    string nString = Console.ReadLine();
                    int n = int.Parse(nString);
                    int digits = nString.Length - 1;


                    int multiplesOfTen = 1;
                    for(var j = 1; j <= digits; j++)
                    {
                        multiplesOfTen *= 10;
                        round = n % multiplesOfTen;

                        if (round != 0)
                        {
                            rounds.Add(round);
                            n -= round;
                        }
                    }
                    rounds.Add(n);

                    Console.WriteLine(rounds.Count);
                    foreach (var number in rounds)
                    {
                        Console.Write(number + " ");
                    }
                    Console.WriteLine();

                    rounds.Clear();
                }

                
            }
        }
    }
}
