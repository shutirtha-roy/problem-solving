using System;

namespace URI2006_IdentifyingTea
{
    class Program
    {
        static void Main(string[] args)
        {
            string S;
            while (!string.IsNullOrEmpty(S = Console.ReadLine()))
            {
                int T = int.Parse(S);
                string value = Console.ReadLine();
                string[] line = value.Split(' ');
                var A = int.Parse(line[0]);
                var B = int.Parse(line[1]);
                var C = int.Parse(line[2]);
                var D = int.Parse(line[3]);
                var E = int.Parse(line[4]);
                int count = 0;

                if (T == A)
                {
                    count++;
                }
                if (T == B)
                {
                    count++;
                }
                if (T == C)
                {
                    count++;
                }
                if (T == D)
                {
                    count++;
                }
                if (T == E)
                {
                    count++;
                }
                Console.WriteLine(count);
            }
        }
    }
}
