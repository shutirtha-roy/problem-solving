#include <string> 

class Solution {
public:

    bool isPalindrome(int x) 
    {
        string value = to_string(x);
        
        for(int i = 0; i < value.length() / 2; i++)
        {
            if((value[i] - '0') != (value[value.length() - 1 - i] - '0'))
                return false;
        }
        
        return true;
        
    }
};