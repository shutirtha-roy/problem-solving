using System;

namespace URI2388_Tacógrafo
{
    class Program
    {
        static void Main(string[] args)
        {
            string S;
            while (!string.IsNullOrEmpty(S = Console.ReadLine()))
            {
                int N = int.Parse(S);
                string[] line;
                var product = 0;

                for (var i = 0; i < N; i++)
                {
                    line = Console.ReadLine().Split(' ');
                    int T = int.Parse(line[0]);
                    int V = int.Parse(line[1]);
                    product += T * V;
                }

                Console.WriteLine(product);
            }
        }
    }
}
