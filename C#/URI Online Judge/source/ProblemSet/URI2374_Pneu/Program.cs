using System;

namespace URI2374_Pneu
{
    class Program
    {
        static void Main(string[] args)
        {
            string S;
            while (!string.IsNullOrEmpty(S = Console.ReadLine())) 
            {
                int N = int.Parse(S);
                int M = int.Parse(Console.ReadLine());
                int difference = N - M;
                Console.WriteLine(difference);
            }
        }
    }
}
