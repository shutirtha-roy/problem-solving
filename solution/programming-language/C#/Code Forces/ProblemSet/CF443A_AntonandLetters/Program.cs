using System;
using System.Collections.Generic;

namespace CF443A_AntonandLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string value;
            while (!string.IsNullOrEmpty(value = Console.ReadLine()))
            {
                string sentence = value.Substring(1, value.Length - 2);
                int count = 0;

                if(sentence == "")
                {
                    Console.WriteLine(count);
                }
                else
                {
                    string[] characters = sentence.Split(", ");

                    HashSet<string> distinctCharacters = new HashSet<string>();

                    foreach(string character in characters)
                    {
                        distinctCharacters.Add(character);
                    }

                    Console.WriteLine(distinctCharacters.Count);
                }

            }
        }
    }
}
