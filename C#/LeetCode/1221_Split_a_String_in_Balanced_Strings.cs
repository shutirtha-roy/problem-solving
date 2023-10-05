public class Solution 
{
    private int HasCorrectCharacter(char character, char specificCharacter) 
        =>  character == specificCharacter ? 1 : 0;

    public int BalancedStringSplit(string s) 
    {
        var totalBalancedString = 0;
        var lCount = 0;
        var rCount = 0;

        foreach(var character in s) 
        {
            lCount += HasCorrectCharacter(character, 'L');
            rCount += HasCorrectCharacter(character, 'R');

            if(lCount == rCount) 
            {
                lCount = 0;
                rCount = 0;
                totalBalancedString++;
            }
        }

        return totalBalancedString;
    }
}