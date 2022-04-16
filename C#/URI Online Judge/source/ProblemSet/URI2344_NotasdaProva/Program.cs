using System;

namespace URI2344_NotasdaProva
{
    class Program
    {
        static void Main(string[] args)
        {
            string N;
            int score;

            while (!string.IsNullOrEmpty(N = Console.ReadLine()))
            {
                score = int.Parse(N);
                if (score >= 86 && score <= 100)
                {
                    Console.WriteLine('A');
                }
                else if (score >= 61)
                {
                    Console.WriteLine('B');
                }
                else if (score >= 36)
                {
                    Console.WriteLine('C');
                }
                else if (score >= 1)
                {
                    Console.WriteLine('D');
                }
                else if (score == 0)
                {
                    Console.WriteLine('E');
                }
            }
        }
    }
}
