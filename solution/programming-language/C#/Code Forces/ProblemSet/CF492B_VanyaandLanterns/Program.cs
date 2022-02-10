using System;
using System.Collections.Generic;

namespace CF492B_VanyaandLanterns
{
    class Program
    {
        static void Main(string[] args)
        {
            string value;
            while (!string.IsNullOrEmpty(value = Console.ReadLine()))
            {
                int n = int.Parse(value.Split(' ')[0]);
                int l = int.Parse(value.Split(' ')[1]);
                Dictionary<(int, int), double> difference = new Dictionary<(int, int), double>();
                double d = 0;
                string[] aValues = Console.ReadLine().Split(' ');
                int[] a = Array.ConvertAll(aValues, s => int.Parse(s));
                Array.Sort(a);

                if(n > 1)
                {
                    for (var i = 0; i < a.Length - 1; i++)
                    {
                        difference[(a[i], a[i + 1])] = Math.Abs((a[i] - a[i + 1])) / 2.0;
                    }

                    if (!difference.ContainsKey((0, a[1])))
                    {
                        difference[(0, a[0])] = Math.Abs(a[0] - 0);
                    }

                    if (!difference.ContainsKey((a[a.Length - 1], l)))
                    {
                        difference[(a[a.Length - 1], l)] = Math.Abs(l - a[a.Length - 1]);
                    }
                }
                else
                {
                    difference[(a[0], 0)] = Math.Abs(a[0] - 0);
                    difference[(a[0], l)] = Math.Abs(a[0] - l);
                }

                foreach(var keys in difference)
                {
                    if (keys.Value > d)
                    {
                        d = keys.Value;
                    }
                }

                Console.WriteLine(string.Format("{0:0.0000000000}", d));
            }
        }
    }
}
