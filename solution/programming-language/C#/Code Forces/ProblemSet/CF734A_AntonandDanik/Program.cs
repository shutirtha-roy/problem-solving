using System;

namespace CF734A_AntonandDanik
{
    class Program
    {
        static void Main(string[] args)
        {
            string value;
            while (!string.IsNullOrEmpty(value = Console.ReadLine()))
            {
                var n = int.Parse(value);
                var rounds = Console.ReadLine();
                var anton = 0;
                var danik = 0;

                foreach (char winner in rounds)
                {
                    if (winner == 'A')
                    {
                        anton++;
                    }
                    else if (winner == 'D')
                    {
                        danik++;
                    }
                }

                if (anton > danik)
                {
                    Console.WriteLine("Anton");
                }
                else if (anton < danik)
                {
                    Console.WriteLine("Danik");
                }
                else
                {
                    Console.WriteLine("Friendship");
                }
            }
        }
    }
}
