using System;

namespace CF339A_HelpfulMaths
{
    class Program
    {
        static void Main(string[] args)
        {
            string value;
            while (!string.IsNullOrEmpty(value = Console.ReadLine()))
            {
                string[] digitsString = value.Split('+');
                int[] digits = new int[digitsString.Length];
                string newString = "";

                for (var i = 0; i < digitsString.Length; i++)
                {
                    digits[i] = int.Parse(digitsString[i]);
                }

                digits = bubbleSort(digits);

                
                for (var i = 0; i < digitsString.Length; i++)
                {
                    if (i != digitsString.Length - 1)
                        newString += digits[i] + "+";
                    else
                        newString += digits[i];
                }

                Console.WriteLine(newString);
            }
        }

        static int[] bubbleSort(int[] values)
        {
            int temp = 0;
            for (var i = 0; i < values.Length; i++)
            {
                for (var j = 0; j < values.Length - 1; j++)
                {
                    if (values[j] > values[j+1])
                    {
                        temp = values[j + 1];
                        values[j + 1] = values[j];
                        values[j] = temp;
                    }
                }
            }
            return values;
        }
    }
}
