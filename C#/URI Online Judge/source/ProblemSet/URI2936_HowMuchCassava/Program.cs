using System;

namespace URI2936_HowMuchCassava
{
    class Program
    {
        static void Main(string[] args)
        {
            string S;
            while (!string.IsNullOrEmpty(S = Console.ReadLine()))
            {
                int C = int.Parse(S);
                int Curupira = 300, Boitatá = 1500, Boto = 600, Mapinguari = 1000, Iara = 150;

                int Curupira_i = C;
                int Boitatá_i = int.Parse(Console.ReadLine());
                int Boto_i = int.Parse(Console.ReadLine());
                int Mapinguari_i = int.Parse(Console.ReadLine());
                int Iara_i = int.Parse(Console.ReadLine());

                int sum = 225 + Curupira * Curupira_i + Boitatá * Boitatá_i + Boto * Boto_i + Mapinguari * Mapinguari_i + Iara * Iara_i;
                Console.WriteLine(sum);
            }
        }
    }
}
