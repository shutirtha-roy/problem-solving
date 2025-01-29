class Solution {
    public int scoreOfString(String s) {
        var score = 0;

        for (var index = 0; index < s.length() - 1; index++) {
            score += Math.abs((int)s.charAt(index) - (int)s.charAt(index+1));
        }

        return score;
    }
}