using System;

namespace URI2413_BuscanaInternet
{
    class Program
    {
        static void Main(string[] args)
        {
            string S;
            while (!string.IsNullOrEmpty(S = Console.ReadLine()))
            {
                int t = int.Parse(S);
                Console.WriteLine(t * 2 * 2);
            }
        }
    }
}
