using System;

namespace CF59A_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            string value;
            while (!string.IsNullOrEmpty(value = Console.ReadLine()))
            {
                char[] characters = value.ToCharArray();
                int[] count = new int[2]; //count[0]->lowerCase count[1]->upperCase

                foreach(char alphabet in characters)
                {
                    if (char.IsUpper(alphabet))
                        ++count[1];
                    else
                        ++count[0];
                }

                Console.WriteLine(checker(count[0], count[1], value));
            }
        }

        static string checker(int lowerCount, int UpperCount, string value)
        {
            if (lowerCount > UpperCount)
                return value.ToLower();
            else if (lowerCount < UpperCount)
                return value.ToUpper();
            else
                return value.ToLower();
        }
    }
}
