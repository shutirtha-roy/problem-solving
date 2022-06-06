public class Solution 
{
    public int[] SmallerNumbersThanCurrent(int[] nums) 
    {
        int[] allNumsCounts = new int[nums.Max() + 1];
        int[] countSmaller = new int[nums.Length];
        
        foreach(int num in nums)
        {
            allNumsCounts[num]++;
        }
        
        for(int i = 1; i < allNumsCounts.Length; i++)
        {
            allNumsCounts[i] = allNumsCounts[i] + allNumsCounts[i - 1];
        }
        
        for(int i = 0; i < nums.Length; i++)
        {
            if(nums[i] != 0)
            {
                countSmaller[i] = allNumsCounts[nums[i] - 1];
            }
            
        }
        
        return countSmaller;
    }
}