public class ReferenceSolution : Solution
{
    public override int LongestCommonSubsequence(string text1, string text2)
    {
        var dp = new int[text2.Length + 1];
        foreach (char c in text1)
        {
            int diagonal = 0;
            for (int j = 1; j <= text2.Length; j++)
            { int old = dp[j]; dp[j] = c == text2[j - 1] ? diagonal + 1 : Math.Max(dp[j], dp[j - 1]); diagonal = old; }
        }
        return dp[^1];
    }
}
