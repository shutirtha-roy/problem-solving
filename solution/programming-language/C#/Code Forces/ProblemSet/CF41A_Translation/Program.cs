using System;

namespace CF41A_Translation
{
    class Program
    {
        static void Main(string[] args)
        {
            string value;
            while (!string.IsNullOrEmpty(value = Console.ReadLine()))
            {
                var s = value;
                var t = Console.ReadLine();
                var j = s.Length - 1;
                var count = 0;

                if (s.Length != t.Length)
                {
                    Console.WriteLine("NO");
                }
                else
                {
                    for (var i = 0; i < s.Length; i++, j--)
                    {
                        if (s[i] == t[j])
                        {
                            count++;
                        }
                    }

                    if (count == s.Length)
                    {
                        Console.WriteLine("YES");
                    }
                    else
                    {
                        Console.WriteLine("NO");
                    }
                }
                
            }
        }
    }
}
