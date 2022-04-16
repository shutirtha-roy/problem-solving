using System;

namespace URI1930_ElectricalOutlet
{
    class Program
    {
        static void Main(string[] args)
        {
            string S;
            while (!string.IsNullOrEmpty(S = Console.ReadLine()))
            {
                string[] T = S.Split(' ');
                var T1 = int.Parse(T[0]);
                var T2 = int.Parse(T[1]);
                var T3 = int.Parse(T[2]);
                var T4 = int.Parse(T[3]);

                var sum = T1 + (T2 - 1) + (T3 - 1) + (T4 - 1);
                Console.WriteLine(sum);
            }
        }
    }
}
