import java.util.Arrays;

/** O(m * n) time, O(n) space. Each cell adds its left and above neighbours. */
class ReferenceSolution extends Solution {
    @Override
    public int uniquePaths(int m, int n) {
        int[] dp = new int[n];
        Arrays.fill(dp, 1);
        for (int row = 1; row < m; row++) {
            for (int column = 1; column < n; column++) {
                dp[column] += dp[column - 1];
            }
        }
        return dp[n - 1];
    }
}
