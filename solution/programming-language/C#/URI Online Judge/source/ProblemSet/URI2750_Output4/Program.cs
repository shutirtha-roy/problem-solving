using System;

namespace URI2750_Output4
{
    class Program
    {
        static void Main(string[] args)
        {
            int zero = 0, one = 1, two = 2, three = 3, four = 4, five = 5, six = 6, seven = 7, eight = 8, nine = 9,
            ten = 10, eleven = 11, twelve = 12, thirteen = 13, fourteen = 14, fifteen = 15;

            fullDashed();
            headerTitle();
            fullDashed();
            middleLines(zero, zero ,zero);
            middleLines(one, one, one);
            middleLines(two, two, two);
            middleLines(three, three, three);
            middleLines(four, four, four);
            middleLines(five, five, five);
            middleLines(six, six, six);
            middleLines(seven, seven, seven);
            middleLines(eight, eight + 2, eight);
            middleLines(nine, nine + 2, nine);
            middleLines(ten, ten + 2, ten);
            middleLines(eleven, eleven + 2, eleven);
            middleLines(twelve, twelve + 2, twelve);
            middleLines(thirteen, thirteen + 2, thirteen);
            middleLines(fourteen, fourteen + 2, fourteen);
            middleLines(fifteen, fifteen + 2, fifteen);
            fullDashed();
        }
        static void fullDashed()
        {
            for (var i = 0; i < 39; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
        }

        static void headerTitle()
        {
            for (var i = 0; i < 39; i++)
            {
                if (i == 0 || i == 12 || i == 22 || i == 38)
                {
                    Console.Write("|");
                }
                else if (i >= 3 && i < 3 + "decimal".Length)
                {
                    Console.Write("decimal"[i - 3]);
                }
                else if (i >= 15 && i < 15 + "octal".Length)
                {
                    Console.Write("octal"[i - 15]);
                }
                else if (i >= 25 && i < 25 + "Hexadecimal".Length)
                {
                    Console.Write("Hexadecimal"[i - 25]);
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }

        static void middleLines(int firstNumber, int secondNumber, int thirdNumber)
        {
            for (var i = 0; i < 39; i++)
            {
                if (i == 0 || i == 12 || i == 22 || i == 38)
                {
                    Console.Write("|");
                }
                else if (i == 7)
                {
                    if (firstNumber >= 10)
                    {
                        Console.Write(firstNumber.ToString()[1]);
                    }
                    else
                    {
                        Console.Write(firstNumber);
                    }
                }
                else if (i == 17)
                {
                    if (secondNumber >= 10)
                    {
                        Console.Write(secondNumber.ToString()[1]);
                    } 
                    else
                    {
                        Console.Write(secondNumber);
                    }
                }
                else if (i == 30)
                {
                    if (thirdNumber >= 10)
                    {
                        Console.Write((char)(65 + thirdNumber - 10));
                    }
                    else
                    {
                        Console.Write(thirdNumber);
                    }
                    
                }
                else if (secondNumber >= 10 && i == 16)
                {
                    Console.Write(secondNumber.ToString()[0]);
                }
                else if (firstNumber >= 10 && i == 6)
                {
                    Console.Write(firstNumber.ToString()[0]);
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}
