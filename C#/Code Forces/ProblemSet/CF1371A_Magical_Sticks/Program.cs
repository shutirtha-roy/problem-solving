using System;

namespace CF1371A_Magical_Sticks
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            for(int i = 0; i < t; i++)
            {
                int n = int.Parse(Console.ReadLine());

                if(n % 2 == 0)
                {
                    Console.WriteLine(n / 2);
                }
                else
                {
                    Console.WriteLine(1 + n / 2);
                }
                    
            }
        }
    }
}
