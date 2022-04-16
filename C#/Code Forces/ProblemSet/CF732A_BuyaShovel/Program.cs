using System;

namespace CF732A_BuyaShovel
{
    class Program
    {
        static void Main(string[] args)
        {
            string value;
            while (!string.IsNullOrEmpty(value = Console.ReadLine()))
            {
                int[] items = Array.ConvertAll(value.Split(' '), s => int.Parse(s));
                int k = items[0];
                int r = items[1];
                int total = 0;
                int i = 1;
                while(true)
                {
                    total = k * i;

                    if(total % 10 == r || total % 10 == 0)
                    {
                        Console.WriteLine(i);
                        break;
                    }

                    i++;
                }
            }
        }
    }
}
