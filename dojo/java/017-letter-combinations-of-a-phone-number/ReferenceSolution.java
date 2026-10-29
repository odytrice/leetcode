import java.util.ArrayList;
import java.util.List;

/** O(4^n) time. Extends every prefix by each letter of the next digit. */
class ReferenceSolution extends Solution {
    // LETTERS[d] is the keypad letters for digit d; 0 and 1 have none.
    private static final String[] LETTERS = {"", "", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz"};

    @Override
    public List<String> letterCombinations(String digits) {
        List<String> result = new ArrayList<>();
        // No digits means no combinations, not one empty combination.
        if (digits.isEmpty()) {
            return result;
        }
        // Seed with the empty prefix so the first digit has something to extend.
        result.add("");
        for (char digit : digits.toCharArray()) {
            // next holds every prefix that covers one more digit than result does.
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
