using System;

namespace CF546A_SoldierandBananas
{
    class Program
    {
        static void Main(string[] args)
        {
            string value;
            while (!string.IsNullOrEmpty(value = Console.ReadLine()))
            {
                var k = int.Parse(Convert.ToString(value.Split(' ')[0]));
                var n = int.Parse(Convert.ToString(value.Split(' ')[1]));
                var w = int.Parse(Convert.ToString(value.Split(' ')[2]));

                var totalCost = mainCost(k, w);

                if (n >= totalCost)
                {
                    Console.WriteLine(0);
                }
                else
                {
                    Console.WriteLine(totalCost - n);
                }
                
            }
        }

        static int mainCost(int initialCost, int total)
        {
            var totalCost = 0;
            
            for (var i = 1; i <= total; i++)
            {
                totalCost += (initialCost * i);
            }

            return totalCost;
        }
    }
}
