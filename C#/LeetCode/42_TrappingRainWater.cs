//TC: O(N), N: size of height
//MC: O(1)
public class Solution 
{
    private int GetCalculatedWater(int maxHeight, int currentHeight)
    {
        return maxHeight - currentHeight > 0 
                ? maxHeight - currentHeight
                : 0;
    }

    public int Trap(int[] height) 
    {
        int leftMax = 0, rightMax = 0;
        int leftIndex = 0, rightIndex = height.Length - 1;
        int waterAmount = 0;

        while(leftIndex < rightIndex)
        {
            leftMax = Math.Max(leftMax, height[leftIndex]);
            rightMax = Math.Max(rightMax, height[rightIndex]);

            if(leftMax <= rightMax)
            {
                waterAmount += GetCalculatedWater(leftMax, height[leftIndex]);
                leftIndex++;
            }

            if(leftMax > rightMax)
            {
                waterAmount += GetCalculatedWater(rightMax, height[rightIndex]);
                rightIndex--;
            }
        }

        return waterAmount;
    }
}