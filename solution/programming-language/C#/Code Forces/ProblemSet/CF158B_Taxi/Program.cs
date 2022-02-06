using System;
using System.Collections.Generic;

namespace CF158B_Taxi
{
    class Program
    {
        static void Main(string[] args)
        {
            string value;
            while (!string.IsNullOrEmpty(value = Console.ReadLine()))
            {
                var n = int.Parse(value);
                string[] sString = Console.ReadLine().Split(' ');

                List<int> s = new List<int>();

                foreach (string aValue in sString)
                {
                    s.Add(int.Parse(aValue));
                }

                
                int count = 0;

                int oneCount = 0, twoCount = 0, threeCount = 0, fourCount = 0;

                for(int i = 0; i < s.Count; i++)
                {
                    if (s[i] == 1)
                        oneCount++;
                    else if (s[i] == 2)
                        twoCount++;
                    else if (s[i] == 3)
                        threeCount++;
                    else if (s[i] == 4)
                        fourCount++;
                }

                count += fourCount;
                fourCount = 0;

                
                if (oneCount > 0 && threeCount > 0)
                {
                    if (oneCount >= threeCount)
                    {
                        count += threeCount;
                        oneCount -= threeCount;
                        threeCount = 0;
                    }
                    else if (oneCount < threeCount)
                    {
                        count += oneCount;
                        threeCount -= oneCount;
                        oneCount = 0;
                    }
                }

                if(threeCount > 0)
                {
                    count += threeCount;
                    threeCount = 0;
                }

                count += (twoCount / 2);
                twoCount -= ((twoCount / 2) * 2);

                if(twoCount > 0)
                {
                    if(oneCount == 0)
                    {
                        count++;
                        twoCount = 0;
                    }
                    else
                    {
                        twoCount += (oneCount / 2);
                        oneCount -= (oneCount / 2) * 2;

                        count += twoCount / 2;
                        twoCount -= ((twoCount / 2) * 2);

                        if(twoCount == 1 && oneCount == 1)
                        {
                            count++;
                            twoCount = 0;
                            oneCount = 0;
                        } 
                        else if(twoCount == 1)
                        {
                            count++;
                            twoCount = 0;
                        }
                        else if(oneCount >= 1)
                        {
                            count++;
                            oneCount = 0;
                        }
                    }
                }


                if(oneCount > 0 && oneCount < 4)
                {
                    count++;
                    oneCount = 0;
                }

                count += oneCount / 4;
                oneCount -= ((oneCount / 4) * 4);

                if (oneCount >= 1)
                    count++;



                Console.WriteLine(count);



            }
        }
    }
}
