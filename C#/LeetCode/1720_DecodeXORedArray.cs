public class Solution {
    public int[] Decode(int[] encoded, int first) {
        int[] a = new int[encoded.Length + 1];
        a[0] = first;
        
        for(int i = 1; i < a.Length; i++)
        {
            a[i] = (a[i-1] ^ encoded[i-1]);
        }
        
        return a;
    }
}