using System;

namespace CF136A_Presents
{
    class Program
    {
        static void Main(string[] args)
        {
            string value;
            while (!string.IsNullOrEmpty(value = Console.ReadLine()))
            {
                int n = int.Parse(value);
                string[] p = Console.ReadLine().Split(' ');
                int[] pInt = new int[n];
                int[] newP = new int[n];

                for (var i = 0; i < p.Length; i++)
                {
                    pInt[i] = int.Parse(p[i]);
                    newP[pInt[i] - 1] = i + 1;
                }

                foreach(int i in newP)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
