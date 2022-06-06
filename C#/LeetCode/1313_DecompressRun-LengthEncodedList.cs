public class Solution 
{
    public int[] generateArray(int arrayLength, int value)
    {
        int[] newArray = new int[arrayLength];
        Array.Fill(newArray, value);
        return newArray;
    }

    public int[] DecompressRLElist(int[] nums)
    {
        int[] decompressArray = generateArray(nums[0], nums[1]);

        for(int i = 2; i < nums.Length; i+=2)
        {
            int[] newArray = generateArray(nums[i], nums[i + 1]);
            decompressArray = decompressArray.Concat(newArray).ToArray();
        }

        return decompressArray;
    }
}