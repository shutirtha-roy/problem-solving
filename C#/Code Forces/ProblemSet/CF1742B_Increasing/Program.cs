using System;
using System.Collections.Generic;
using System.Linq;

namespace B
{
    public class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            for(int i = 0; i < t; i++)
            {
                int n = int.Parse(Console.ReadLine());
                long[] a = Array.ConvertAll(Console.ReadLine().Split(' '), s => long.Parse(s));
                List<long> list = new List<long>();
                bool flag = true;

                for(int j = 0; j < a.Length; j++)
                {
                    if(list.Contains(a[j]))
                    {
                        flag = false;
                        break;
                    }
                    else
                    {
                        list.Add(a[j]);
                    }
                }

                if(flag)
                    Console.WriteLine("YES");
                else
                    Console.WriteLine("NO");

                list.Clear();
            }    

            

        }
    }
}