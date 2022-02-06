using System;

namespace CF112A_PetyaandStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string value;
            while (!string.IsNullOrEmpty(value = Console.ReadLine()))
            {
                var firstWord = value.ToLower();
                var secondWord = Console.ReadLine().ToLower();
                var firstCount = 0;
                var secondCount = 0;
                var count = 0;

                for (var i = 0; i < firstWord.Length; i++)
                {
                    if (!firstWord[i].Equals(secondWord[i]))
                    {
                        if ((int)firstWord[i] > (int)secondWord[i])
                        {
                            firstCount++;
                            break;
                        }
                        else
                        {
                            secondCount++;
                            break;
                        }
                    }
                    else
                    {
                        count++;
                    }
                }

                if (firstWord.Length == count)
                {
                    Console.WriteLine(0);
                }
                else if (firstCount > secondCount)
                {
                    Console.WriteLine(1);
                }
                else if (secondCount > firstCount)
                {
                    Console.WriteLine(-1);
                }

            }
        }
    }
}
