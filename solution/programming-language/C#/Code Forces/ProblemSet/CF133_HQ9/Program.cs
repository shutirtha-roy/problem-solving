using System;

namespace CF133_HQ9
{
    class Program
    {
        static void Main(string[] args)
        {
            string value;
            while (!string.IsNullOrEmpty(value = Console.ReadLine()))
            {
                if (value.Contains('H') || value.Contains('Q') || value.Contains('9'))
                {
                    Console.WriteLine("YES");
                }
                else if (value.Contains('+'))
                {
                    if (value.Length == 1)
                    {
                        Console.WriteLine("NO");
                    }
                    else if (char.IsDigit(value[0]) && !char.IsDigit(value[1]))
                    {
                        Console.WriteLine("NO");
                    }
                    else if (char.IsDigit(value[0]))
                    {
                        Console.WriteLine("YES");
                    }
                    else
                    {
                        Console.WriteLine("NO");
                    }
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
        }
    }
}
