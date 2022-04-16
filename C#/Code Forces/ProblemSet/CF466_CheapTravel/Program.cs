using System;

namespace CF466A_CheapTravel
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string value;
            while (!string.IsNullOrEmpty(value = Console.ReadLine()))
            {
                int n = int.Parse(value.Split(' ')[0]);
                int m = int.Parse(value.Split(' ')[1]);
                int a = int.Parse(value.Split(' ')[2]);
                int b = int.Parse(value.Split(' ')[3]);

                int oneRideSubwayCheaper = OneRideSubwayCheaper(n, m, a, b);
                int specialRideSubwayCheaper = SpecialRideSubwayCheaper(n, m, a, b);
                int mixedRideSubwayCheaper = MixedRideSubwayCheaper(n, m, a, b);


                int minPrice = Math.Min(oneRideSubwayCheaper, Math.Min(specialRideSubwayCheaper, mixedRideSubwayCheaper));

                if(m > n)
                {
                    if (n * a < b)
                        minPrice = n * a;
                    else
                        minPrice = b;

                }


                Console.WriteLine(minPrice);
            }
        }

        private static int OneRideSubwayCheaper(int n, int m, int a, int b)
        {
            return n * a;
        }

        private static int SpecialRideSubwayCheaper(int n, int m, int a, int b)
        {
            if (n % m == 0)
                return (n / m) * b;
            else
                return (n / m) * b + b;
        }

        private static int MixedRideSubwayCheaper(int n, int m, int a, int b)
        {
            int normalTicket = n % m;
            int mTicket = n / m;
                
            return normalTicket * a + mTicket * b;
        }
    }
}