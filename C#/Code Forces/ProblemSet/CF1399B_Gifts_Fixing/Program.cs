using System;
using System.Linq;

namespace CF1399B_Gifts_Fixing
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
                int[] b = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));

                long minMove = 0;
                int aMin = a.Min();
                int bMin = b.Min();
                
                for (int j = 0; j < n; j++)
                {
                    if (a[j] == aMin && b[j] == bMin)
                        continue;

                    if(a[j] - aMin <= b[j] - bMin)
                    {
                        minMove += b[j] - bMin;
                    }
                    else
                    {
                        minMove += a[j] - aMin;
                    }
                }

                Console.WriteLine(minMove);
            }
        }
    }
}
