using System;

namespace CF1230A_Dawid_and_Bags_of_Candies
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));
            Array.Sort(a);

            if(a[0] + a[1] + a[2] == a[3] ||  a[0] + a[1] == a[2] + a[3] || a[0] + a[2] == a[1] + a[3] || a[0] + a[3] == a[1] + a[2])
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
    }
}
