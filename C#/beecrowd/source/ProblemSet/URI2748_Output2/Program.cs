using System;

namespace URI2748_Output2
{
    class Program
    {
        static void Main(string[] args)
        {
            fullDashed();
            stringInserter("Roberto");
            exclamation();
            stringInserter("5786");
            exclamation();
            stringInserter("UNIFEI");
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

        static void exclamation()
        {
            for (var i = 0; i < 39; i++)
            {
                if (i == 0 || i == 38)
                {
                    Console.Write("|");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }

        static void stringInserter(string value)
        {
            for (var i = 0; i < 39; i++)
            {
                if (i == 0 || i == 38)
                {
                    Console.Write("|");
                }
                else if (i >= 9 && i < 9 + value.Length)
                {
                    Console.Write(value[i - 9]);
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
