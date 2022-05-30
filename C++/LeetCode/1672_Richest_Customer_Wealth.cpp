class Solution {
public:
    int maximumWealth(vector<vector<int>>& accounts) {
        
        vector<int> wealthList;
        int maxSize = 0;
        int sum = 0;
        
        for(int i = 0; i < accounts.size(); i++)
        {
            sum = 0;
            for(int j = 0; j < accounts[0].size(); j++)
            {
                sum += accounts[i][j];
            }
            
            wealthList.push_back(sum);
        }
        
        return *max_element(wealthList.begin(), wealthList.end());
    }
};