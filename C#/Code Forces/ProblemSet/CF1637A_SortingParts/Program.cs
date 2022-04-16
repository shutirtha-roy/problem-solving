using System;
using System.Linq;

namespace CF1637A_SortingParts
{
    class Program
    {
        static void Main(string[] args)
        {
            string value;
            while (!string.IsNullOrEmpty(value = Console.ReadLine()))
            {
                int t = int.Parse(value);

                for (var i = 0; i < t; i++)
                {
                    int arrayLength = int.Parse(Console.ReadLine());
                    int[] array = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));
                    int[] newArray = new int[array.Length];
                    array.CopyTo(newArray, 0);

                    Array.Sort(array);

                    if (newArray.SequenceEqual(array))
                    {
                        Console.WriteLine("NO");
                    }
                    else
                    {
                        Console.WriteLine("YES");
                    }
                }

            }
        }
    }
}
