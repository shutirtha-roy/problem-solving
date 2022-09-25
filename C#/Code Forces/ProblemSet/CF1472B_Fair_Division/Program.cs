using System;
using System.Linq;

namespace CF1472B_Fair_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                int n = int.Parse(Console.ReadLine());
                int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));
                int oneCount = a.Count(s => s == 1);
                int twoCount = a.Count(s => s == 2);
                int totalCount = oneCount + 2 * twoCount;

                if(oneCount == 0 && n % 2 == 0)
                    Console.WriteLine("YES");
                else if(totalCount % 2 == 0 && oneCount >= 2)
                    Console.WriteLine("YES");
                else
                    Console.WriteLine("NO");
            }
        }
    }
}
