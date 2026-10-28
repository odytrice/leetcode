/** O(len1 * len2) time, O(len2) space. Keeps one row and the diagonal. */
class ReferenceSolution extends Solution {
    @Override
    public int longestCommonSubsequence(String text1, String text2) {
        int[] dp = new int[text2.length() + 1];
        for (char first : text1.toCharArray()) {
            int diagonal = 0;
            for (int column = 1; column <= text2.length(); column++) {
                int previous = dp[column];
                dp[column] = first == text2.charAt(column - 1)
                        ? diagonal + 1
                        : Math.max(dp[column], dp[column - 1]);
                diagonal = previous;
            }
        }
        return dp[text2.length()];
    }
}
