using System;
using System.Collections.Generic;

namespace CF228A_IsYourHorseShoeoOTheOtherHoof
{
    public class Program
    {
        static void Main(string[] args)
        {
            string value;
            while (!string.IsNullOrEmpty(value = Console.ReadLine()))
            {
                HashSet<int> uniqueColor = new HashSet<int>();
                string[] s = value.Split(' ');
                int totalNeeded = 0;
                
                foreach (var digit in s)
                {
                    uniqueColor.Add(int.Parse(digit));
                }

                totalNeeded = 4 - uniqueColor.Count;

                Console.WriteLine(totalNeeded);
            }
        }
    }
}
