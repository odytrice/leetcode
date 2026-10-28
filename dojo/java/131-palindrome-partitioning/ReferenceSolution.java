import java.util.ArrayList;
import java.util.List;

/** O(n * 2^n) time. Precomputes palindromes, then cuts wherever one ends. */
class ReferenceSolution extends Solution {
    @Override
    public List<List<String>> partition(String s) {
        int size = s.length();
        boolean[][] palindrome = new boolean[size][size];
        for (int start = size - 1; start >= 0; start--) {
            for (int end = start; end < size; end++) {
                palindrome[start][end] = s.charAt(start) == s.charAt(end)
                        && (end - start < 2 || palindrome[start + 1][end - 1]);
            }
        }

        List<List<String>> result = new ArrayList<>();
        search(s, palindrome, 0, new ArrayList<>(), result);
        return result;
    }

    private void search(String s, boolean[][] palindrome, int start, List<String> path, List<List<String>> result) {
        if (start == s.length()) {
            result.add(new ArrayList<>(path));
            return;
        }
        for (int end = start; end < s.length(); end++) {
            if (palindrome[start][end]) {
                path.add(s.substring(start, end + 1));
                search(s, palindrome, end + 1, path, result);
                path.remove(path.size() - 1);
            }
        }
    }
}
