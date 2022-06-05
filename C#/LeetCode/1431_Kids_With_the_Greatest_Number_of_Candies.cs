public class Solution 
{
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) 
    {
        IList<bool> candyCondition = new List<bool>();
        int maxValue = candies.Max();
        
        foreach(int candy in candies)
        {
            if(candy + extraCandies >= maxValue)
            {
                candyCondition.Add(true);
                continue;
            }
            
            candyCondition.Add(false);
        }
        
        return candyCondition;
    }
}