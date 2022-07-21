using System;

namespace CF802G_Fake_News
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string heidi = "heidi";

            int count = 0;

            for(int i = 0; i < s.Length; i++)
            {
                if (count == 5)
                    break;

                if (s[i] == heidi[count])
                    count++;
            }

            if (count == 5)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
    }
}
