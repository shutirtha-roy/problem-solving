using System;

namespace CF1281A_Suffix_Three
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            for(int i = 0; i < t; i++)
            {
                string sentence = Console.ReadLine();

                if(sentence.EndsWith("po"))
                    Console.WriteLine("FILIPINO");
                else if(sentence.EndsWith("desu") || sentence.EndsWith("masu"))
                    Console.WriteLine("JAPANESE");
                else if(sentence.EndsWith("mnida"))
                    Console.WriteLine("KOREAN");
            }
        }
    }
}
