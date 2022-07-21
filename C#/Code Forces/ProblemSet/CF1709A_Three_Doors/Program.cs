using System;
using System.Collections.Generic;

namespace CF1709A_Three_Doors
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            for(int i = 1; i <= t; i++)
            {
                int x = int.Parse(Console.ReadLine());
                int[] keysBehind = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));
                IDictionary<int, bool> doorUnlock = new Dictionary<int, bool>()
                {
                    { 1, false },
                    { 2, false },
                    { 3, false }
                };

                int count = 1;
                int key = x;
                bool flag = true;

                int key1 = 0, key2 = 0, key3 = 0;
                doorUnlock[key] = true;

                if (key > 0 && doorUnlock[key] == true) 
                {
                    key1 = keysBehind[key - 1];
                    doorUnlock[key1] = true;
                }
                else
                    flag = false;

                if (key1 > 0 && doorUnlock[key1] == true)
                { 
                    key2 = keysBehind[key1 - 1];
                    doorUnlock[key2] = true;
                }
                else
                    flag = false;

                if (key2 > 0 && doorUnlock[key2] == true)
                { 
                    key3 = keysBehind[key2 - 1];
                    doorUnlock[key3] = true;
                }
                else
                    flag = false;
                

                if(flag)
                    Console.WriteLine("YES");
                else
                    Console.WriteLine("NO");
            }
        }
    }
}
