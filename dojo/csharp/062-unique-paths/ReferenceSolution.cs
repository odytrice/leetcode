public class ReferenceSolution : Solution
{
    public override int UniquePaths(int m, int n)
    {
        var dp = Enumerable.Repeat(1, n).ToArray();
        for (int r = 1; r < m; r++) for (int c = 1; c < n; c++) dp[c] += dp[c - 1];
        return dp[^1];
    }
}
