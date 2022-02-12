using System;

namespace CF581A_VasyatheHipster
{
    class Program
    {
        static void Main(string[] args)
        {
            string value;
            while (!string.IsNullOrEmpty(value = Console.ReadLine()))
            {
                int[] integerValues = Array.ConvertAll(value.Split(' '), s => int.Parse(s));
                int a = integerValues[0];
                int b = integerValues[1];
                int differentSock = 0;
                int sameSock = 0;

                if(a >= b)
                {
                    differentSock = b;
                    a -= b;
                    sameSock = a / 2;
                }
                else
                {
                    differentSock = a;
                    b -= a;
                    sameSock = b / 2;
                }

                Console.WriteLine($"{differentSock} {sameSock}");
            }
        }
    }
}
