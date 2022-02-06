using System;

namespace URI3302_CorrectAnswer
{
    class Program
    {
        static void Main(string[] args)
        {
            string value;
            while (!string.IsNullOrEmpty(value = Console.ReadLine()))
            {
                int N = int.Parse(value);
                int[] Ni = new int[N];

                for (var i = 0; i < N; i++)
                {
                    Ni[i] = int.Parse(Console.ReadLine());
                    Console.WriteLine("resposta " + (i + 1) + ": " + Ni[i]);
                }
            }
        }
    }
}
