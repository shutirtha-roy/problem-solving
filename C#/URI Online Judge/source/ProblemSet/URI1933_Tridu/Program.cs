using System;

namespace URI1933_Tridu
{
    class Program
    {
        static void Main(string[] args)
        {
            string S;
            while (!string.IsNullOrEmpty(S = Console.ReadLine()))
            {
                var A = int.Parse(S.Split(' ')[0]);
                var B = int.Parse(S.Split(' ')[1]);

                if (A > B)
                {
                    Console.WriteLine(A);
                } 
                else
                {
                    Console.WriteLine(B);
                }

            }
        }
    }
}
