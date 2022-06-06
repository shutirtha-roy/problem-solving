public class Solution {
    public string RestoreString(string s, int[] indices) {
        char[] newPattern = new char[s.Length];
        
        for(int i = 0; i < indices.Length; i++)
        {
            newPattern[indices[i]] = s.ElementAt(i);
        }
        
        return new string(newPattern);
    }
}