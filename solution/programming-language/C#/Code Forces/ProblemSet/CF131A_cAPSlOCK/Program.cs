using System;
using System.Text;

namespace CF131A_cAPSlOCK
{
    public class Program
    {
        static void Main(string[] args)
        {
            string value;
            StringBuilder newString = new StringBuilder();

            while(!string.IsNullOrEmpty(value = Console.ReadLine()))
            {
                string capsString = value;

                if(capsString[0] == char.ToUpper(capsString[0]))
                {
                    if(capsString.Substring(1).Equals(capsString.Substring(1).ToUpper()))
                    {
                        newString.Append(capsString.ToLower());
                    }

                }
                else if(capsString[0] == char.ToLower(capsString[0]))
                {
                    if (capsString.Length == 1)
                    {
                        GetNewString(capsString, ref newString);
                    }
                    else if (capsString.Substring(1).Equals(capsString.Substring(1).ToUpper()))
                    {
                        GetNewString(capsString, ref newString);
                    }
                }

                
                if(newString.Length == 0)
                {
                    Console.WriteLine(capsString);
                }
                else
                {
                    Console.WriteLine(newString);
                }
                

                newString.Clear();
            }
        }

        static void GetNewString(string capsString, ref StringBuilder newString)
        {
            for (var i = 0; i < capsString.Length; i++)
            {
                if (i == 0)
                {
                    newString.Append(char.ToUpper(capsString[i]));
                }
                else
                {
                    newString.Append(char.ToLower(capsString[i]));
                }

                if (capsString.Length == 1)
                {
                    break;
                }

            }
        }
    }
}
