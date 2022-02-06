using System;

namespace URI2749_Output3
{
    class Program
    {
        static void Main(string[] args)
        {
            fullDashed();
            stringInserter("x = 35", 1);
            exclamation();
            stringInserter("x = 35", 16);
            exclamation();
            stringInserter("x = 35", 32);
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

        static void stringInserter(string value, int index)
        {
            for (var i = 0; i < 39; i++)
            {
                if (i == 0 || i == 38)
                {
                    Console.Write("|");
                }
                else if (i >= index && i < index + value.Length)
                {
                    Console.Write(value[i - index]);
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
