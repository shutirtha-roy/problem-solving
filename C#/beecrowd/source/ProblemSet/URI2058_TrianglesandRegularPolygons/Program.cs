using System;

namespace URI2058_TrianglesandRegularPolygons
{
    class Program
    {
        static void Main(string[] args)
        {
            string S;
            while (!string.IsNullOrEmpty(S = Console.ReadLine()))
            {
                int N = int.Parse(S);
                Console.WriteLine(N - 2);
            }
        }
    }
}
