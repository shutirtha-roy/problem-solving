using System;

namespace URI1858_TheonsAnswer
{
    class Program
    {
        static void Main(string[] args)
        {
            string value;
            while (!string.IsNullOrEmpty(value = Console.ReadLine()))
            {
                var N = int.Parse(value);
                int[] T = new int[N];
                var Tn = Console.ReadLine().Split(' ');
                
                for (var i = 0; i < N; i++)
                {
                    T[i] = int.Parse(Tn[i]);
                }
                var leastHit = minimum(T);
                Console.WriteLine(leastHit);
            }
        }

        static int minimum(int[] T)
        {
            int min = T[0];
            int index = 1;

            for (var i = 0; i < T.Length; i++)
            {
                if (min > T[i])
                {
                    min = T[i];
                    index = i+1;
                }
            }
            return index;
        }
    }
}
