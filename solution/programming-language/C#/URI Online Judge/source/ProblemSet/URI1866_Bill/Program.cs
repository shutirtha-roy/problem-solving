using System;

namespace URI1866_Bill
{
    class Program
    {
        static void Main(string[] args)
        {
            var C = int.Parse(Console.ReadLine());

            for (var i = 0; i < C; i++)
            {
                var N = int.Parse(Console.ReadLine());
                if (N % 2 == 0)
                {
                    Console.WriteLine(0);
                } 
                else
                {
                    Console.WriteLine(1);
                }
            }
        }
    }
}
