using System;
using System.Collections.Generic;

namespace CF158A_NextRound
{
    class Program
    {
        static void Main(string[] args)
        {
            string value;
            while (!string.IsNullOrEmpty(value = Console.ReadLine()))
            {
                int n = int.Parse(value.Split(' ')[0]);
                int k = int.Parse(value.Split(' ')[1]);

                string[] aString = Console.ReadLine().Split(' ');

                List<int> a = new List<int>();

                foreach(string aValue in aString)
                {
                    a.Add(int.Parse(aValue));
                }

                int kElement = a[k - 1];
                int kPos = k - 1;
                int count = 0;

                for(int i = 0; i < a.Count; i++)
                {
                    if (a[i] >= kElement && a[i] > 0)
                        count++;
                }

                Console.WriteLine(count);
            }

        }
    }
}
