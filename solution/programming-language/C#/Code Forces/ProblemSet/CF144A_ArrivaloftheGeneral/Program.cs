using System;

namespace CF144A_ArrivaloftheGeneral
{
    class Program
    {
        static void Main(string[] args)
        {
            string value;
            while (!string.IsNullOrEmpty(value = Console.ReadLine()))
            {
                int n = int.Parse(value);
                string[] positions = Console.ReadLine().Split(' ');
                int[] a = Array.ConvertAll(positions, s => int.Parse(s));
                int count = 0;
                int minValue, minIndex, maxValue, maxIndex;
                (minValue, minIndex, maxValue, maxIndex) = GetInitialMinMax(a);

                int temp = 0;
                for(var i = minIndex; i < a.Length - 1; i++)
                {
                    temp = a[i];
                    a[i] = a[i + 1];
                    a[i + 1] = temp;
                    count++;
                }

                (minValue, minIndex, maxValue, maxIndex) = GetInitialMinMax(a);

                for (var i = maxIndex; i >= 1; i--)
                {
                    temp = a[i];
                    a[i] = a[i - 1];
                    a[i - 1] = temp;
                    count++;
                }

                Console.WriteLine(count);
            }
        }

        static (int, int, int, int) GetInitialMinMax(int[] a)
        {
            int minValue = a[0], maxValue = a[0], minIndex = 0, maxIndex = 0;

            for(var i = 0; i < a.Length; i++)
            {
                if(minValue >= a[i])
                {
                    minValue = a[i];
                    minIndex = i;
                } 
                else if (maxValue < a[i])
                {
                    maxValue = a[i];
                    maxIndex = i;
                }
            }

            return (minValue, minIndex, maxValue, maxIndex);
        }
    }


}
