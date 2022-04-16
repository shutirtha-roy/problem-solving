using System;

namespace CF266B_QueueattheSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            string value;
            while(!string.IsNullOrEmpty(value = Console.ReadLine()))
            {
                int n = int.Parse(value.Split(' ')[0]);
                int t = int.Parse(value.Split(' ')[1]);
                string s = Console.ReadLine();

                if(n == 1 || t == 0)
                {
                    Console.WriteLine(s);
                }
                else
                {
                    char[] sCharacters = s.ToCharArray();

                    for(var i = 0; i < t; i++)
                    {
                        sCharacters = PositionSwapper(sCharacters);
                    }

                    Console.WriteLine(new string(sCharacters));
                }
            }
        }


        static char[] PositionSwapper(char[] sCharacters)
        {
            char temp;
            
            for(var i = 0; i < sCharacters.Length - 1;)
            {
                if(sCharacters[i] == 'B' && sCharacters[i+1] == 'G')
                {
                    temp = sCharacters[i];
                    sCharacters[i] = sCharacters[i + 1];
                    sCharacters[i + 1] = temp;
                    i += 2;
                    continue;
                }

                i += 1;
            }
            
            
            return sCharacters;
        }
    }
}
