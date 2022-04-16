using System;

namespace CF344A_Magnets
{
    class Program
    {
        static void Main(string[] args)
        {
            string value;
            while (!string.IsNullOrEmpty(value = Console.ReadLine()))
            {
                var n = int.Parse(value);
                var group = 1;

                var previousGroup = Console.ReadLine();

                for (var i = 1; i < n; i++)
                {
                    string inputString = Console.ReadLine();
                    if (!(previousGroup == inputString))
                    {
                        group++;
                    }
                    previousGroup = inputString;
                }

                Console.WriteLine(group);
            }
        }
    }
}
