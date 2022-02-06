using System;

namespace CF118A_StringTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string value;
            while (!string.IsNullOrEmpty(value = Console.ReadLine()))
            {
                char[] letters = value.ToLower().ToCharArray();
                string newSentence = "";
                //"A", "O", "Y", "E", "U", "I",
                foreach (char letter in letters)
                {
                    if (!(letter == 'a' || letter == 'o' || letter == 'y' || letter == 'e' || letter == 'u' || letter == 'i'))
                    {
                        newSentence += "." + letter;
                    }
                }

                Console.WriteLine(newSentence);
            }
        }
    }
}
