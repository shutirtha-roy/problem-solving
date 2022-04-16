using System;

namespace CF677A_VanyaandFence
{
    class Program
    {
        static void Main(string[] args)
        {
            string value;
            while (!string.IsNullOrEmpty(value = Console.ReadLine()))
            {
                var n = value;
                var h = Console.ReadLine().Split(' ');

                var numberOfFriends = int.Parse(n.Split(' ')[0]);
                var heightOfFence = int.Parse(n.Split(' ')[1]);
                var count = 0;

                for (var i = 0; i < numberOfFriends; i++)
                {
                    if (int.Parse(h[i]) <= heightOfFence)
                    {
                        ++count;
                    }
                    else
                    {
                        count += 2;
                    }
                }

                Console.WriteLine(count);
            }
        }
    }
}
