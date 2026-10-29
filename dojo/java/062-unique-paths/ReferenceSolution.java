import java.util.Arrays;

/** O(m * n) time, O(n) space. Each cell adds its left and above neighbours. */
class ReferenceSolution extends Solution {
    @Override
    public int uniquePaths(int m, int n) {
        // dp[column] is the number of paths to that column in the current row.
        int[] dp = new int[n];
        // The first row and first column can each be reached only one way.
        Arrays.fill(dp, 1);
        for (int row = 1; row < m; row += 1) {
            for (int column = 1; column < n; column += 1) {
                // dp[column] still holds the cell above; dp[column - 1] is the cell to the left.
                dp[column] += dp[column - 1];
            }
        }
        return dp[n - 1];
    }
}
