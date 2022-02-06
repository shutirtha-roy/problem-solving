using System;

namespace URI1865_Mjolnir
{
    class Program
    {
        static void Main(string[] args)
        {
            string value;
            while (!string.IsNullOrEmpty(value = Console.ReadLine()))
            {
                var C = int.Parse(value);
                string character;
                int N;

                for (var i = 0; i < C; i++)
                {
                    var values = Console.ReadLine().Split(' ');
                    character = values[0];
                    N = int.Parse(values[1]);
                    if (character == "Thor")
                    {
                        Console.WriteLine('Y');
                    }
                    else
                    {
                        Console.WriteLine('N');
                    }
                }
            }
        }
    }
}
