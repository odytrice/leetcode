public class ReferenceSolution : Solution
{
    public override bool WordBreak(string s, IList<string> wordDict)
    {
        var words = wordDict.ToHashSet(); int max = wordDict.Max(w => w.Length);
        var dp = new bool[s.Length + 1]; dp[0] = true;
        for (int end = 1; end <= s.Length; end++)
        for (int start = Math.Max(0, end - max); start < end; start++)
            if (dp[start] && words.Contains(s[start..end])) { dp[end] = true; break; }
        return dp[^1];
    }
}
