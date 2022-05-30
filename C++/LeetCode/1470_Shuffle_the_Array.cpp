class Solution {
public:
    vector<int> shuffle(vector<int>& nums, int n) {
        vector<int> newNums(nums.size(), 0);
        
        for(int i = 0; i < 2 * n; i += 2)
        {
            newNums[i] = nums[i / 2];
            newNums[i + 1] = nums[n + i / 2];
        }
        
        return newNums;
    }
};