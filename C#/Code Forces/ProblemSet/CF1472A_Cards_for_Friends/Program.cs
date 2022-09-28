using System;

namespace CF1472A_Cards_for_Friends
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));
                int w = a[0], h = a[1], n = a[2];
                int times = 1;

                while(w % 2 == 0)
                {
                    times *= 2;

                    if (w % 2 == 0)
                        w /= 2;
                }

                while(h % 2 == 0)
                {
                    times *= 2;

                    if (h % 2 == 0)
                        h /= 2;
                }

                if(n <= times)
                    Console.WriteLine("YES");
                else
                    Console.WriteLine("NO");
            }
        }
    }
}
