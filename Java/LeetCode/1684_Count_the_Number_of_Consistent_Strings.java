class Solution {
    public int countConsistentStrings(String allowed, String[] words) {
        Map<Character, Boolean> allowedMap = new HashMap<>();

        for (var index = 0; index < allowed.length(); index++) {
            allowedMap.put(allowed.charAt(index), true);
        }

        var totalWords = 0;
        for (String word:words) {
            var containsRightKey = true;

            for (var index = 0; index < word.length(); index++) {
                if (!allowedMap.containsKey(word.charAt(index))) {
                    containsRightKey = false;
                    break;
                }
            }

            if (containsRightKey) {
                totalWords++;
            }
        }

        return totalWords; 

    }
}