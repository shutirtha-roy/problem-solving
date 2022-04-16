using System;

namespace CF977A_WrongSubtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            string value;
            while (!string.IsNullOrEmpty(value = Console.ReadLine()))
            {
                var n = int.Parse(Convert.ToString(value.Split(' ')[0]));
                var k = int.Parse(Convert.ToString(value.Split(' ')[1]));
                string nString = Convert.ToString(n);

                for (var i = 1; i <= k; i++)
                {
                    if (int.Parse(Convert.ToString(nString[nString.Length - 1])) != 0)
                    {
                        n = --n;
                        nString = Convert.ToString(n);
                    }
                    else
                    {
                        n = n / 10;
                        nString = Convert.ToString(n);
                    }
                }

                Console.WriteLine(nString);

            }
        }
    }
}
