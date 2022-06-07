public class Solution {
    public int[] CreateTargetArray(int[] nums, int[] index) {
        int[] targetArray = new int[index.Length];
        int idx = 0;
        Array.Fill(targetArray, -1);
        
        for(int i = 0; i < nums.Length; i++)
        {
            idx = index[i];
            
            if(targetArray[idx] != -1)
            {
                for(int j = nums.Length - 2; j >= idx; j--)
                {
                    targetArray[j + 1] = targetArray[j];
                }
            }
            
            targetArray[idx] = nums[i];
        }
        
        return targetArray;
        
    }
}