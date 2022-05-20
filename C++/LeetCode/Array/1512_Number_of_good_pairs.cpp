class Solution {
public:
    int sum(int value)
    {
        if(value == 0)
            return 0;
        
        return value + sum(value - 1);
    }
    
    
    int numIdenticalPairs(vector<int>& nums) 
    {
        int prev, count = 0, initialCount = 1;
        
        sort(nums.begin(), nums.end());
        prev = nums[0];
        
        for(int i = 1; i < nums.size(); i++)
        {
            if(prev != nums[i])
            {
                count += sum(initialCount - 1);
                initialCount = 0;
            }
            
            initialCount += 1;
            prev = nums[i];
        }
        
        if(nums[nums.size() - 1] == nums[nums.size() - 2])
            count += sum(initialCount - 1);
        
        return count;
    }
};