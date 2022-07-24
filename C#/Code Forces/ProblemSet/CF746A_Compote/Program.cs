using System;

namespace CF746A_Compote
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int count = 0;

            while(a >= 0)
            {
                if(a * 2 <= b && a * 4 <= c)
                {
                    count = a;
                    break;
                }

                a--;
            }

            Console.WriteLine(count + count * 2 + count * 4);
        }
    }
}
