class Solution {
public:
    int removeDuplicates(vector<int>& nums) {
        
        int count = 0;
        vector<int> nonDuplicateNum;
        int lengthNums = nums.size();
        
        for(int i = 0; i < nums.size() - 1; i++)
        {
            if(nums[i] == nums[i + 1])
            {
                nums.erase(nums.begin() + i--);
            }
        }

        
        return nums.size();
    }
};