using System;

namespace CF999A_Mishka_and_Contest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));
            int n = values[0];
            int k = values[1];

            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));

            int count = 0;
            int startIndex = -1;

            for(int i = 0; i < a.Length; i++)
            {
                if (a[i] > k)
                {
                    startIndex = i;
                    break;
                }
                    
                count++;
            }

            if (startIndex == -1)
                startIndex = a.Length - 1;

            for(int i = a.Length - 1; i >= startIndex + 1; i--)
            {
                if (a[i] > k)
                    break;

                count++;
            }

            Console.WriteLine(count);
        }
    }
}
