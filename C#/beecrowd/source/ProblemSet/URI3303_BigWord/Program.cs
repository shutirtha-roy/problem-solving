using System;

namespace URI3303_BigWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string value;
            while (!string.IsNullOrEmpty(value = Console.ReadLine()))
            {
                int size = value.Length;
                if(size >= 10)
                {
                    Console.WriteLine("palavrao");
                } 
                else
                {
                    Console.WriteLine("palavrinha");
                }
            }
        }
    }
}
