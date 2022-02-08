using System;

namespace CF148A_Insomniacure
{
    class Program
    {
        static void Main(string[] args)
        {
            string value;
            while (!string.IsNullOrEmpty(value = Console.ReadLine()))
            {
                int k = int.Parse(value);
                int l = int.Parse(Console.ReadLine());
                int m = int.Parse(Console.ReadLine());
                int n = int.Parse(Console.ReadLine());
                int d = int.Parse(Console.ReadLine());
                int count = 0;

                for(var i = 1; i <= d; i++)
                {
                    if(i % k != 0 && i % l != 0 && i % m != 0 && i % n != 0)
                    {
                        count += 1;
                    }
                }

                int damagedDragons = d - count;

                Console.WriteLine(damagedDragons);
                
            }
        }
    }
}