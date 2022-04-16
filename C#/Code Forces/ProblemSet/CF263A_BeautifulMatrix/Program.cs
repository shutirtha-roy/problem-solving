using System;

namespace CF263A_BeautifulMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            string value;
            while (!string.IsNullOrEmpty(value = Console.ReadLine()))
            {
                string[] row = new string[5];
                row[0] = value;
                
                for (var i = 1; i < row.Length; i++)
                {
                    row[i] = Console.ReadLine();
                }

                int[ , ] matrix = new int[5, 5];
                int iLoc = 0, jLoc = 0;

                for (var i = 0; i < matrix.GetLength(0); i++)
                {
                    for (var j = 0; j < matrix.GetLength(1); j++)
                    {
                        matrix[i, j] = int.Parse(row[i].Split(' ')[j]);

                        if (matrix[i, j] == 1)
                        {
                            iLoc = i;
                            jLoc = j;
                            break;
                        }
                    }
                }

                int iBeautiful = 2, jBeautiful = 2;
                int count = 0;

                if (iBeautiful >= iLoc)
                {
                    count += iBeautiful - iLoc;
                }
                else
                {
                    count += iLoc - iBeautiful;
                }

                if (jBeautiful >= jLoc)
                {
                    count += jBeautiful - jLoc;
                }
                else
                {
                    count += jLoc - jBeautiful;
                }

                Console.WriteLine(count);
            }
        }
    }
}
