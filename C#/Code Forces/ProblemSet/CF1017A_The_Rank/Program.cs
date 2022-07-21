using System;
using System.Linq;

namespace CF1017A_The_Rank
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for(int i = 0; i < n; i++)
            {
                int[] student = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));
                arr[i] = student.Sum();
            }

            int thomasScore = arr[0];

            Array.Sort(arr);
            Array.Reverse(arr);

            for(int i = 0; i < n; i++)
            {
                if(thomasScore == arr[i])
                {
                    Console.WriteLine(i + 1);
                    break;
                }
                    
            }
        }
    }
}
