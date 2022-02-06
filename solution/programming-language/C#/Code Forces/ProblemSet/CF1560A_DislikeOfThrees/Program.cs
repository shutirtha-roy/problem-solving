using System;

namespace CF1560A_DislikeOfThrees
{
    class Program
    {
        static void Main(string[] args)
        {
            string value;
            while (!string.IsNullOrEmpty(value = Console.ReadLine()))
            {
                int t = int.Parse(value);

                for (var i = 0; i < t; i++)
                {
                    string k = Console.ReadLine();
                    var checker = 0;
                    int[] a = new int[int.Parse(k)];
                    a[a.Length - 1] = -1;

                    for (var j = 1; a[a.Length - 1] == -1; j++)
                    {
                        if (!(j % 3 == 0 || Convert.ToString(j).EndsWith('3')))
                        {
                            a[checker] = j;
                            checker++;
                        }
                    }
                    Console.WriteLine(a[a.Length - 1]);
                }
            }
        }
    }
}
