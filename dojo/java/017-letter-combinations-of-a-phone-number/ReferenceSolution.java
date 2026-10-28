import java.util.ArrayList;
import java.util.List;

/** O(4^n) time. Extends every prefix by each letter of the next digit. */
class ReferenceSolution extends Solution {
    private static final String[] LETTERS = {"", "", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz"};

    @Override
    public List<String> letterCombinations(String digits) {
        List<String> result = new ArrayList<>();
        if (digits.isEmpty()) {
            return result;
        }
        result.add("");
        for (char digit : digits.toCharArray()) {
            List<String> next = new ArrayList<>();
            for (String prefix : result) {
                for (char letter : LETTERS[digit - '0'].toCharArray()) {
                    next.add(prefix + letter);
                }
            }
            result = next;
        }
        return result;
    }
}
