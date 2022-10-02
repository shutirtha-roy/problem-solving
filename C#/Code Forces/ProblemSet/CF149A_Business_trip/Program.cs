using System;

namespace CF149A_Business_trip
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());
            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));
            int count = 0;

            Array.Sort(a);
            Array.Reverse(a);

            for(int i = 0; i < a.Length; i++)
            {
                if (k <= 0)
                    break;

                k -= a[i];
                count++;
            }

            if(k > 0)
                Console.WriteLine(-1);
            else
                Console.WriteLine(count);
        }
    }
}
