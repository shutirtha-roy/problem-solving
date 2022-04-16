using System;
using System.Collections.Generic;

namespace CF1633A_Div7
{
    class Program
    {
        static void Main(string[] args)
        {
            string value;
            while (!string.IsNullOrEmpty(value = Console.ReadLine()))
            {
                int t = int.Parse(value);

                for(var i = 0; i < t; i++)
                {
                    Console.WriteLine(DivisionBySevenChecker(int.Parse(Console.ReadLine())));
                }
            }
        }

        static int DivisionBySevenChecker(int number)
        {
            if (DivisibleBySeven(number))
            {
                return number;
            }
            else
            {
                return IfNotDivisibleBySeven(number);
            }
        }

        static bool DivisibleBySeven(int number)
        {
            if (number % 7 == 0)
            {
                return true;
            }

            return false;
        }

        static int IfNotDivisibleBySeven(int number)
        {
            if(number.ToString().Length == 2)
            {
                return Tens(number);
            }
            else if(number.ToString().Length == 3)
            {
                return Hundreds(number);
            }

            return -1;
        }

        static int Tens(int number)
        {
            string numberString = number.ToString();

            int counter = 0;
            for(var i = 0; i < numberString.Length; i++)
            {
                for(var j = 1 - counter; j <= 9; j++)
                {
                    if(i == 0)
                    {
                        if (DivisibleBySeven(int.Parse(j.ToString() + numberString[1])))
                        {
                            return int.Parse(j.ToString() + numberString[1]);
                        }
                    }
                    else if (i == 1)
                    {
                        if (DivisibleBySeven(int.Parse(numberString[0] + j.ToString())))
                        {
                            return int.Parse(numberString[0] + j.ToString());
                        }
                    }
                }
                counter = 1;
            }
            
            return -1;
        }

        static int Hundreds(int number)
        {
            string numberString = number.ToString();

            int counter = 0;
            for (var i = 0; i < numberString.Length; i++)
            {
                for (var j = 1 - counter; j <= 9; j++)
                {
                    if (i == 0)
                    {
                        if (DivisibleBySeven(int.Parse(j.ToString() + numberString[1] + numberString[2])))
                        {
                            return int.Parse(j.ToString() + numberString[1] + numberString[2]);
                        }
                    }
                    else if (i == 1)
                    {
                        if (DivisibleBySeven(int.Parse(numberString[0] + j.ToString() + numberString[2])))
                        {
                            return int.Parse(numberString[0] + j.ToString() + numberString[2]);
                        }
                    }
                    else if (i == 3)
                    {
                        if (DivisibleBySeven(int.Parse(numberString[0]  + numberString[1] + j.ToString())))
                        {
                            return int.Parse(numberString[0] + numberString[1] + j.ToString());
                        }
                    }
                }
                counter = 1;
            }

            return -1;
        }

    }
}
