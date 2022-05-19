class Solution 
{
public:
    vector<int> buildArray(vector<int>& nums) 
    {
        int size = nums.size();
        vector<int> newArray(size);
        
        for(int i = 0; i < size; i++)
            newArray[i] = nums[nums[i]];
        
        return newArray;
    }
};