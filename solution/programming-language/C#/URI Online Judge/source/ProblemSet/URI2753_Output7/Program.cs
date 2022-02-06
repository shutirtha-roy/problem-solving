using System;

namespace URI2753_Output7
{
    class Program
    {
        static void Main(string[] args)
        {
            int noOfAlphabet = 26;
            
            for (var i = 97; i < noOfAlphabet + 97; i++)
            {
                Console.WriteLine(i + " e " + (char)i);
            }
        }
    }
}
