using System;

public class Solution 
{
    public int StrStr(string haystack, string needle) 
    {
        for (var index = 0; index <= haystack.Length - needle.Length; index++)
        {
            if(haystack.Substring(index, needle.Length).Equals(needle))
            {
                return index;
            }
        }

        return -1;
    }
}