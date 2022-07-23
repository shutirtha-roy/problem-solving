using System;

namespace CF867A_Between_the_Offices
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string val = Console.ReadLine();

            if (val[0] == 'S' && val[val.Length - 1] == 'F')
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
    }
}
