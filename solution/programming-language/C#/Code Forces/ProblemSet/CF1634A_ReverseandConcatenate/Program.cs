using System;

namespace CF1634A_ReverseandConcatenate
{
    class Program
    {
        static void Main(string[] args)
        {
            string value;
            while (!string.IsNullOrEmpty(value = Console.ReadLine()))
            {
                int t = int.Parse(value);
                int n;
                int k;
                string s;

                for (var i = 0; i < t; i++)
                {
                    string numberLine = Console.ReadLine();
                    n = int.Parse(numberLine.Split(' ')[0]);
                    k = int.Parse(numberLine.Split(' ')[1]);
                    s = Console.ReadLine();

                    if (k != 0)
                    {
                        Console.WriteLine(DifferentStringGetter(n, k, s));
                    }
                    else
                    {
                        Console.WriteLine(1);
                    }


                }

            }
        }

        static int DifferentStringGetter(int n, int k, string s)
        {
            string newS = s;
            string firstString = newS;
            string secondString = newS;

            firstString = StringAdder(firstString, ReverseString(s));
            secondString = StringAdder(ReverseString(s), secondString);

            if (firstString != secondString)
            {
                return 2;
            }
            else
            {
                return 1;
            }
        }

        static string ReverseString(string myStr)
        {
            char[] myArr = myStr.ToCharArray();
            Array.Reverse(myArr);
            return new string(myArr);
        }

        static string StringAdder(string stringOne, string stringTwo)
        {
            return stringOne + stringTwo;
        }

    }
}
