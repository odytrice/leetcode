public class ReferenceSolution : Solution
{
    // O(m * n) time, O(n) space. Each cell adds the paths from its left and from above.
    public override int UniquePaths(int m, int n)
    {
        var dp = Enumerable.Repeat(1, n).ToArray();
        for (int r = 1; r < m; r += 1)
        {
            for (int c = 1; c < n; c += 1)
            {
                dp[c] += dp[c - 1];
            }
        }
        return dp[^1];
    }
}
