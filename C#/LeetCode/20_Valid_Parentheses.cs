//TC: O(N), where N is the length of the string
//MC: O(N)

public class Solution 
{
    public bool IsValid(string s) 
    {
        var parenthesisPair = new Dictionary<char, char>();
        parenthesisPair[')'] = '(';
        parenthesisPair['}'] = '{';
        parenthesisPair[']'] = '[';
        Stack<char> stack = new Stack<char>();


        foreach(var character in s)
        {
            if(character == '(' || character == '{' || character == '[')
            {
                stack.Push(character);
            }
            
            var isStackEmpty = stack.Count == 0;

            if(isStackEmpty
                && character == ')' || character == '}' || character == ']')
            {
                return false;
            }

            
            if (character == ')' || character == '}' || character == ']') 
            {
                if(isStackEmpty || (!isStackEmpty 
                    && stack.Peek() != parenthesisPair[character])) 
                {
                    return false;
                }

                stack.Pop();
            }
        }

        return stack.Count == 0;
    }
}