using System;

namespace CF282A_Bit__
{
    class Program
    {
        static void Main(string[] args)
        {
            string value;
            while (!string.IsNullOrEmpty(value = Console.ReadLine()))
            {
                int n = int.Parse(value);
                int count = 0;

                string[] x = new string[n];

                for (var i = 0; i < n; i++)
                {
                    x[i] = Console.ReadLine();
                    if (x[i].Contains("++"))
                    {
                        count++;
                    }
                    else if (x[i].Contains("--"))
                    {
                        count--;
                    }
                }

                Console.WriteLine(count);
                
            }
        }
    }
}
