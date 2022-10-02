using System;
using System.Collections.Generic;
using System.Linq;

namespace CF977B_Two_gram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();

            IDictionary<string, int> subPair = new Dictionary<string, int>();

            for(int i = 0; i < s.Length; i += 1)
            {
                if (i + 1 == s.Length)
                    break;

                if(!subPair.ContainsKey(s.Substring(i, 2)))
                {
                    subPair.Add(s.Substring(i, 2), 0);
                }
                else
                {
                    subPair[s.Substring(i, 2)] += 1;
                }
            }

            string value = subPair.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
            Console.WriteLine(value);

        }
    }
}
