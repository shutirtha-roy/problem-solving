using System;

namespace CF266A_StonesontheTable
{
    class Program
    {
        static void Main(string[] args)
        {
            string value;
            while (!string.IsNullOrEmpty(value = Console.ReadLine()))
            {
                var n = int.Parse(value);
                string s = Console.ReadLine();
                char previousColor, nextColor;
                int count = 0;

                previousColor = s[0];

                for (var i = 1; i < n; i++)
                {
                    nextColor = s[i];
                    if (previousColor == nextColor)
                    {
                        count++;
                    }
                    previousColor = nextColor;
                }
                Console.WriteLine(count);
            }
        }
    }
}
