class Solution {

    private boolean hasCharacters(String word, char x) {
        for (var index = 0; index < word.length(); index++) {
            if (word.charAt(index) == x) {
                return true;
            }
        }
        return false;
    }

    public List<Integer> findWordsContaining(String[] words, char x) {
        var indexList = new ArrayList<Integer>();
        var count = 0;

        for (String word: words) {
            if(hasCharacters(word, x)) {
                indexList.add(count);
            }
            count++;
        }

        return indexList;
    }
}