using System;
using System.Collections;

namespace CF236A_BoyorGirl
{
    class Program
    {
        static void Main(string[] args)
        {
            string value;
            while(!string.IsNullOrEmpty(value = Console.ReadLine()))
            {
                ArrayList arlist = new ArrayList();
                char[] characters = value.ToCharArray();

                arlist.Add(characters[0]);

                var distinctCount = 1;

                for (var i = 1; i < characters.Length; i++)
                {
                    if (!arlist.Contains(characters[i]))
                    {
                        distinctCount++;
                    }
                    arlist.Add(characters[i]);
                }

                if (distinctCount % 2 == 1)
                {
                    Console.WriteLine("IGNORE HIM!");
                }
                else
                {
                    Console.WriteLine("CHAT WITH HER!");
                }
            }
        }
    }
}
