using System;

namespace CF467_GeorgeandAccommodation
{
    class Program
    {
        static void Main(string[] args)
        {
            string value;
            while (!string.IsNullOrEmpty(value = Console.ReadLine()))
            {
                var n = int.Parse(value);
                var count = 0;

                for (var i = 0; i < n; i++)
                {
                    var peopleRoom = Console.ReadLine().Split(' ');
                    var person = int.Parse(peopleRoom[0]);
                    var capacity = int.Parse(peopleRoom[1]);

                    if (person + 1 < capacity)
                    {
                        count++;
                    }
                }

                Console.WriteLine(count);
            }
        }
    }
}
