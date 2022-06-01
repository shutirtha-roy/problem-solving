class Solution {
public:
    int romanToInt(string s) {
        map<char, int> romalNumerals;
        romalNumerals['I'] = 1;
        romalNumerals['V'] = 5;
        romalNumerals['X'] = 10;
        romalNumerals['L'] = 50;
        romalNumerals['C'] = 100;
        romalNumerals['D'] = 500;
        romalNumerals['M'] = 1000;
        
        char previousNumber = s.at(0);
        int total = romalNumerals[previousNumber];
        
        for(int i = 1; i < s.length(); i++)
        {
            total += romalNumerals[s.at(i)];
            
            if(romalNumerals[previousNumber] < romalNumerals[s.at(i)])
                total -= romalNumerals[previousNumber] * 2;

            previousNumber = s.at(i);
        }
        
        return total;
    }
};