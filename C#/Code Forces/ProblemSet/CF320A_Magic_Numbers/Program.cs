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
                        if (int.Parse(value.Substring(i, 3)) == 144)
                        {
                            i += 3;
                        }
                        else if (int.Parse(value.Substring(i, 2)) == 14)
                        {
                            i += 2;
                        }
                        else if ((int)value[i] - '0' == 1)
                        {
                            i++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    else if (i < value.Length - 1)
                    {
                        if (int.Parse(value.Substring(i, 2)) == 14)
                        {
                            i += 2;
                        }
                        else if ((int)value[i] - '0' == 1)
                        {
                            i++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    else if((int)value[i] - '0' == 1)
                    {
                        i++;
                    }
                    else
                    {
                        break;
                    }
                    
                }

                if (i == value.Length)
                    Console.WriteLine("YES");
                else
                    Console.WriteLine("NO");
            }

        }
    }
}
