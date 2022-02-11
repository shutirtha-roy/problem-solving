using System;

namespace CF339B_XeniaandRingroad
{
    class Program
    {
        static void Main(string[] args)
        {
            string value;
            while (!string.IsNullOrEmpty(value = Console.ReadLine()))
            {
                var values = value.Split(' ');
                long n = long.Parse(values[0]);
                long m = long.Parse(values[1]);
                long[] a = Array.ConvertAll(Console.ReadLine().Split(' '), s => long.Parse(s));
                long count = 0l;

                count = a[0] - 1l;

                if(m > 1l)
                {
                    for(long i = 1l; i < m; i++)
                    {
                        if(a[i] < a[i - 1l])
                        {
                            count += (n - a[i - 1l]) + a[i];
                        } 
                        else if(a[i] >= a[i - 1l])
                        {
                            count += (a[i] - a[i - 1l]);
                        }
                    }
                }

                Console.WriteLine(count);
            }
        }
    }
}
