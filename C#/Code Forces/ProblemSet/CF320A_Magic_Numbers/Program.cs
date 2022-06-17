using System;

namespace CF320A_Magic_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string value;
            while (!string.IsNullOrEmpty(value = Console.ReadLine()))
            {
                int i = 0;

                while (i < value.Length)
                {
                    if(i < value.Length - 2)
                    {
                        if (int.Parse(value.Substring(i, 3)) == 444)
                            break;
                    }
                    
                    if (value[0] != '1')
                        break;
                    else if ((int)value[i] - '0' != 1 && (int)value[i] - '0' != 4)
                        break;

                    i++;
                }

                if (i == value.Length)
                    Console.WriteLine("YES");
                else
                    Console.WriteLine("NO");
            }

        }
    }
}
