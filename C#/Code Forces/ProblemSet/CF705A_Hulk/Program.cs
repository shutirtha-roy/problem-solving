using System;
using System.Text;

namespace CF705A_Hulk
{
    public class Program
    {
        static void Main(string[] args)
        {
            string value;
            while (!string.IsNullOrEmpty(value = Console.ReadLine()))
            {
                int n = int.Parse(value);

                StringBuilder str = new StringBuilder();
                
                
                for(var i = 1; i <= n; i++)
                {
                    if(i % 2 == 1)
                    {
                        str.Append("I hate");
                    }
                    else
                    {
                        str.Append("I love");
                    }

                    str.Append(" that ");
                }

                str.Remove(str.Length - " that".Length, " that".Length);

                str.Append("it");

                Console.WriteLine(str);

                
            }
        }
    }
}
