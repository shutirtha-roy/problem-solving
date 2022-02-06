using System;

namespace CF791A_BearandBigBrother
{
    class Program
    {
        static void Main(string[] args)
        {
            string value;
            while (!string.IsNullOrEmpty(value = Console.ReadLine()))
            {
                var a = int.Parse(Convert.ToString(value.Split(' ')[0]));
                var b = int.Parse(Convert.ToString(value.Split(' ')[1]));
                var count = 0;

                if (a == b)
                {
                    Console.WriteLine(++count);
                }
                else
                {
                    var sizeOfA = a;
                    var sizeOfB = b;

                    while (sizeOfA <= sizeOfB)
                    {
                        sizeOfA = 3 * sizeOfA;
                        sizeOfB = 2 * sizeOfB;
                        count++;
                    }

                    Console.WriteLine(count);
                }
            }
        }
    }
}
