using System;
using System.Collections.Generic;

namespace CF38A_Army
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] oldD = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));

            int[] ab = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));
            int a = ab[0];
            int b = ab[1];

            b--;
            a--;

            int total = 0;
            for(int i = a; i < b; i++)
            {
                total += oldD[i];
            }

            Console.WriteLine(total);

        }
    }
}
