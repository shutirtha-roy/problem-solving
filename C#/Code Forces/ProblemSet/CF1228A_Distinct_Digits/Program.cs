using System;

namespace CF1228A_Distinct_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lr = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));

            int l = lr[0], r = lr[1];
            bool flag = false;
            int answer = -1;

            for(int i = l; i <= r; i++)
            {
                char[] digits = i.ToString().ToCharArray();
                Array.Sort(digits);
                int count = 1;
                for(int j = 0; j < digits.Length - 1; j++)
                {
                    if(digits[j] != digits[j + 1])
                    {
                        count++;
                    }
                }

                if (count == digits.Length)
                {
                    answer = i;
                    break;
                }
                    
            }

            if(answer == -1)
                Console.WriteLine(-1);
            else
                Console.WriteLine(answer);

        }
    }
}
