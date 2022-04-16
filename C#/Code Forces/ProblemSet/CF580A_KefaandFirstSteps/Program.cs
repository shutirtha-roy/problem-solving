using System;
using System.Collections.Generic;
using System.Linq;

namespace CF580A_KefaandFirstSteps
{
    public class Program
    {
        static void Main(string[] args)
        {
            string value;
            while (!string.IsNullOrEmpty(value = Console.ReadLine()))
            {
                string[] a = Console.ReadLine().Split(' ');
                List<int> counter = new List<int>();

                int previousValue = int.Parse(a[0]);

                int count = 1;
                for(var i = 1; i < a.Length; i++)
                {
                    if(int.Parse(a[i]) >= previousValue)
                    {
                        count++;
                        previousValue = int.Parse(a[i]);
                    }
                    else
                    {
                        counter.Add(count);
                        previousValue = int.Parse(a[i]);
                        count = 1;
                    }
                }
                counter.Add(count);

                Console.WriteLine(counter.Max());

            }
        }
    }
}
