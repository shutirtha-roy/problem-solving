public class Solution {
    public int CountMatches(IList<IList<string>> items, string ruleKey, string ruleValue) {
        var ruleKeyDict = new Dictionary<string, int>();
        var count = 0;
        
        ruleKeyDict.Add("type", 0);
        ruleKeyDict.Add("color", 1);
        ruleKeyDict.Add("name", 2);
        
        foreach(var ruleList in items)
        {
            if(ruleList[ruleKeyDict[ruleKey]].Equals(ruleValue))
                count++;
        }
        
        return count;
    }
}