using System;
using System.Collections.Generic;

namespace CF785A_AntonandPolyhedrons
{
    class Program
    {
        static void Main(string[] args)
        {
            string value;
            while (!string.IsNullOrEmpty(value = Console.ReadLine()))
            {
                int n = int.Parse(value);
                int total = 0;

                Dictionary<string, int> collectionItems = new Dictionary<string, int>();
                collectionItems.Add("Tetrahedron", 4);
                collectionItems.Add("Cube", 6);
                collectionItems.Add("Octahedron", 8);
                collectionItems.Add("Dodecahedron", 12);
                collectionItems.Add("Icosahedron", 20);

                for (var i = 0; i < n; i++)
                {
                    total += collectionItems[Console.ReadLine()];
                }

                Console.WriteLine(total);
            }
        }
    }
}
