import java.util.HashSet;
import java.util.List;
import java.util.Set;

/** O(n * max word length) time. dp[i] is true when the prefix of length i can be segmented. */
class ReferenceSolution extends Solution {
    @Override
    public boolean wordBreak(String s, List<String> wordDict) {
        Set<String> words = new HashSet<>(wordDict);
        int longest = 0;
        for (String word : wordDict) {
            longest = Math.max(longest, word.length());
        }
        boolean[] dp = new boolean[s.length() + 1];
        dp[0] = true;
        for (int end = 1; end <= s.length(); end++) {
            for (int start = Math.max(0, end - longest); start < end; start++) {
                if (dp[start] && words.contains(s.substring(start, end))) {
                    dp[end] = true;
                    break;
                }
            }
        }
        return dp[s.length()];
    }
}
