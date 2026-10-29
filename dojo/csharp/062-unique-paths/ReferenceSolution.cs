public class ReferenceSolution : Solution
{
    // O(m * n) time, O(n) space. Each cell adds the paths from its left and from above.
    public override int UniquePaths(int m, int n)
    {
        // dp[c] is the number of paths to column c of the current row; the first row is all 1s.
        var dp = Enumerable.Repeat(1, n).ToArray();
        for (int r = 1; r < m; r += 1)
        {
            // Column 0 stays 1: only one path runs straight down the left edge.
            for (int c = 1; c < n; c += 1)
            {
                // dp[c] still holds the count from above; dp[c - 1] is the count from the left.
                dp[c] += dp[c - 1];
            }
        }
        return dp[^1];
    }
}
