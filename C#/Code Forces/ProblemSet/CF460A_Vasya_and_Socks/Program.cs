using System;

namespace CF460A_Vasya_and_Socks
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nm = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));
            int n = nm[0], m = nm[1];
            
            for(int i = 1; m * i <= n; i++)
            {
                n++;
            }

            Console.WriteLine(n);
        }
    }
}
