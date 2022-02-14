using System;
using System.Collections.Generic;

namespace CF427A_PoliceRecruits
{
    class Program
    {
        static void Main(string[] args)
        {
            string value;
            while (!string.IsNullOrEmpty(value = Console.ReadLine()))
            {
                int n = int.Parse(value);
                int[] crimeCondition = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));
                int recruitCount = 0;
                bool recruit = false;
                bool crime = false;
                int crimeCount = 0;
                int untreatedCrime = 0;

                for(var i = 0; i < n; i++)
                {
                    if(crimeCondition[i] <= -1)
                    {
                        crimeCount -= crimeCondition[i];
                        crime = true;
                    } 
                    else if(crimeCondition[i] >= 1)
                    {
                        recruitCount += crimeCondition[i];
                        recruit = true;
                    }

                    if (crime == true && recruitCount == 0)
                    {
                        untreatedCrime++;
                    }
                    else if(crime == true && recruitCount >= 1)
                    {
                        recruitCount--;
                        crimeCount--;
                    }

                    recruit = false;
                    crime = false;
                }

                Console.WriteLine(untreatedCrime);
            }
        }
    }
}
