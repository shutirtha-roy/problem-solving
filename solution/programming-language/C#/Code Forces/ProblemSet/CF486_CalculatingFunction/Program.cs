using System;

namespace CF486_CalculatingFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            string value;
            while (!string.IsNullOrEmpty(value = Console.ReadLine()))
            {
                long n = long.Parse(value);
                long fn = 0;

                if (n % 2 == 0)
                {
                    fn = n / 2;
                }
                else
                {
                    fn = -n/2 - 1;
                }

                Console.WriteLine(fn);
            }
        }
    }
}
