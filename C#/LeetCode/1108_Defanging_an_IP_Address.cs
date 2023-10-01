//TC: O(N), where N is the length of the string
//MC: O(N)

public class Solution 
{
    public string DefangIPaddr(string address) 
    {
        var defrangedIP = string.Empty;
        var dot = '.';
        
        foreach (var character in address)
        {
            if(character == '.') 
            {
                defrangedIP += "[.]";
                continue;
            }

            defrangedIP += character;
        }

        return defrangedIP;
    }
}