using System;
using System.Collections.Generic;

namespace CF520A_Pangram
{
    class Program
    {
        static void Main(string[] args)
        {
            string value;
            while (!string.IsNullOrEmpty(value = Console.ReadLine()))
            {
                int n = int.Parse(value);
                string sentence = Console.ReadLine().ToLower();

                Dictionary<char, int> valuePairs = new Dictionary<char, int>();

                for(var i = (int)'a'; i <= (int)'z'; i++)
                {
                    valuePairs.Add((char)i, 0);
                }
          

                foreach (char alphabet in sentence)
                {
                    valuePairs[alphabet] += 1;
                }

                int counter = 0;
                foreach(var (character, count) in valuePairs)
                {
                    if (count == 0)
                    {
                        counter++;
                        break;
                    }
                }

                if(counter == 1)
                {
                    Console.WriteLine("NO");
                }
                else
                {
                    Console.WriteLine("YES");
                }
            }
        }
    }
}
