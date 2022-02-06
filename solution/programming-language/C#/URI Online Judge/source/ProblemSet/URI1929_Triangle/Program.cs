using System;

namespace URI1929_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string value;
            while (!string.IsNullOrEmpty(value = Console.ReadLine()))
            {
                int A, B, C, D;
                var values = value.Split(' ');
                A = int.Parse(values[0]);
                B = int.Parse(values[1]);
                C = int.Parse(values[2]);
                D = int.Parse(values[3]);

                int[] arrayValue = new int[4];
                arrayValue[0] = A;
                arrayValue[1] = B;
                arrayValue[2] = C;
                arrayValue[3] = D;

                arrayValue = sortArray(arrayValue);

                if (arrayValue[0] + arrayValue[1] > arrayValue[2] || arrayValue[1] + arrayValue[2] > arrayValue[3])
                {
                    Console.WriteLine('S');
                }
                else
                {
                    Console.WriteLine('N');
                }
            }
        }

        static int[] sortArray(int[] arrayValue)
        {
            int temp = 0;
            for (var i = 0; i < arrayValue.Length; i++)
            {
                for (var j = 0; j < arrayValue.Length - i - 1; j++)
                {
                    if (arrayValue[j] > arrayValue[j + 1])
                    {
                        temp = arrayValue[j];
                        arrayValue[j] = arrayValue[j + 1];
                        arrayValue[j + 1] = temp;
                    }
                }
            }
            return arrayValue;
        }
    }
}
