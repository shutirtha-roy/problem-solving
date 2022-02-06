using System;

namespace CF281A_WordCapitalization
{
    class Program
    {
        static void Main(string[] args)
        {
            string value;
            while (!string.IsNullOrEmpty(value = Console.ReadLine()))
            {
                string firstLetter = Convert.ToString(value[0]).ToUpper();

                string newString = firstLetter + value.Substring(1);

                Console.WriteLine(newString);
            }
        }
    }
}
