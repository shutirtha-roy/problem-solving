using System;

namespace CF141A_AmusingJoke
{
    class Program
    {
        static void Main(string[] args)
        {
            string value;
            while (!string.IsNullOrEmpty(value = Console.ReadLine()))
            {
                string guestName = value;
                string residenceHost = Console.ReadLine();
                string pileLetter = Console.ReadLine();

                string joinedArrangedName = guestName + residenceHost;

                if(pileLetter.Length == joinedArrangedName.Length)
                {
                    char[] arrangedSentence = joinedArrangedName.ToCharArray();
                    char[] disorganizedSentence = pileLetter.ToCharArray();

                    Array.Sort<char>(arrangedSentence);
                    Array.Sort<char>(disorganizedSentence);
                    bool flag = false;


                    for(var i = 0; i < arrangedSentence.Length; i++)
                    {
                        if(arrangedSentence[i] != disorganizedSentence[i])
                        {
                            flag = true;
                            break;
                        }
                    }

                    if(flag == true)
                    {
                        Console.WriteLine("NO");
                    }
                    else
                    {
                        Console.WriteLine("YES");
                    }

                }
                else
                {
                    Console.WriteLine("NO");
                }


            }
        }
    }
}
