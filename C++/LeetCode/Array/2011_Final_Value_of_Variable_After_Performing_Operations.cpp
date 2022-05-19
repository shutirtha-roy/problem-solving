class Solution {
public:
    int finalValueAfterOperations(vector<string>& operations) {
        
        int value = 0;
        
        for(string operation : operations)
        {
            for(char character : operation)
            {
                if(character == '+') 
                {
                    value += 1;
                    break;
                }
                else if(character == '-')
                {
                    value -= 1;
                    break;
                }
            }
        }
        
        return value;
    }
};