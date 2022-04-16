using System;

namespace CF405A_GravityFlip
{
    class Program
    {
        static void Main(string[] args)
        {
            string value;
            while (!string.IsNullOrEmpty(value = Console.ReadLine()))
            {
                int n = int.Parse(value);
                string[] arr = Console.ReadLine().Split(' ');
                int[] myInts = Array.ConvertAll(arr, s => int.Parse(s));
                Array.Sort(myInts);

                foreach(var num in myInts)
                {
                    Console.Write($"{num} ");
                }

                Console.WriteLine();
            }
        }
    }
}
