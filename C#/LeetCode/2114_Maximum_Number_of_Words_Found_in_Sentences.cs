public class Solution {
    public int MostWordsFound(string[] sentences) {
        
        int maximumWord = 0;
        
        foreach(string sentence in sentences)
        {
            int sentenceLength = sentence.Split(' ').Length;
            maximumWord = Math.Max(maximumWord, sentenceLength);
        }
        
        return maximumWord;
    }
}