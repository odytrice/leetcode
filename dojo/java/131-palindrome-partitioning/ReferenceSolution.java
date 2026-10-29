import java.util.ArrayList;
import java.util.List;

/** O(n * 2^n) time. Precomputes palindromes, then cuts wherever one ends. */
class ReferenceSolution extends Solution {
    @Override
    public List<List<String>> partition(String s) {
        int size = s.length();
        // palindrome[start][end] is true when s[start..end] reads the same both ways.
        boolean[][] palindrome = new boolean[size][size];
        // Fill start from the right so the inner range [start + 1][end - 1] is ready first.
        for (int start = size - 1; start >= 0; start -= 1) {
            for (int end = start; end < size; end += 1) {
                // Ends match, and the inside is empty, one character, or itself a palindrome.
                palindrome[start][end] = s.charAt(start) == s.charAt(end)
                        && (end - start < 2 || palindrome[start + 1][end - 1]);
            }
        }

        List<List<String>> result = new ArrayList<>();
        search(s, palindrome, 0, new ArrayList<>(), result);
        return result;
    }

    private void search(String s, boolean[][] palindrome, int start, List<String> path, List<List<String>> result) {
        // The whole string has been cut into palindromes.
        if (start == s.length()) {
            result.add(new ArrayList<>(path));
            return;
        }
        // Try every palindrome that begins at start as the next piece.
        for (int end = start; end < s.length(); end += 1) {
            if (palindrome[start][end]) {
                path.add(s.substring(start, end + 1));
                search(s, palindrome, end + 1, path, result);
                path.remove(path.size() - 1);
            }
        }
    }
}
