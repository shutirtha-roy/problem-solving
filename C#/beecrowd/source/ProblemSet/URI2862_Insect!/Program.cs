using System;

namespace URI2862_Insect_
{
    class Program
    {
        static void Main(string[] args)
        {
            var C = int.Parse(Console.ReadLine());
            var N = 0;

            for (var i = 0; i < C; i++)
            {
                N = int.Parse(Console.ReadLine());
                
                if (N > 8000)
                {
                    Console.WriteLine("Mais de 8000!");
                } 
                else
                {
                    Console.WriteLine("Inseto!");
                }
            }
        }
    }
}
