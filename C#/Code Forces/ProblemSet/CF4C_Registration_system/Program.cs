using System;
using System.Collections.Generic;

namespace CF4C_Registration_system
{
    class Program
    {
        static void Main(string[] args)
        {
            IDictionary<string, int> database = new Dictionary<string, int>();

            int n = int.Parse(Console.ReadLine());
            while(n > 0)
            {
                string data = Console.ReadLine();

                if (!database.ContainsKey(data))
                { 
                    database.Add(data, 0);
                    Console.WriteLine("OK");
                }
                else
                { 
                    Console.WriteLine($"{data}{++database[data]}");
                }

                n--;
            }
        }
    }
}
