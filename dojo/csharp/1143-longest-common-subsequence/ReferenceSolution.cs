public class ReferenceSolution : Solution
{
    // O(m * n) time, O(n) space. One row of the DP table, plus the diagonal from the previous row.
    public override int LongestCommonSubsequence(string text1, string text2)
    {
        // dp[j] is the LCS length of the text1 prefix so far and text2[..j].
        var dp = new int[text2.Length + 1];
        foreach (char c in text1)
        {
            // diagonal holds dp[j - 1] from the previous row, which a matching pair extends.
            int diagonal = 0;
            for (int j = 1; j <= text2.Length; j += 1)
            {
                // Save the old value; it is the next column's diagonal.
                int old = dp[j];
                // A match extends the diagonal; otherwise drop the last character of one string or the other.
                dp[j] = c == text2[j - 1] ? diagonal + 1 : Math.Max(dp[j], dp[j - 1]);
                diagonal = old;
            }
        }
        return dp[^1];
    }
}
