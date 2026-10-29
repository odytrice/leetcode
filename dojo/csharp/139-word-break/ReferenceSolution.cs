public class ReferenceSolution : Solution
{
    // O(n * maxWord) checks. dp[i] is true when s[..i] splits into dictionary words.
    public override bool WordBreak(string s, IList<string> wordDict)
    {
        var words = wordDict.ToHashSet();
        int max = wordDict.Max(w => w.Length);
        var dp = new bool[s.Length + 1];
        // The empty prefix needs no words.
        dp[0] = true;
        for (int end = 1; end <= s.Length; end += 1)
        {
            // Only words up to the longest dictionary length can end here.
            for (int start = Math.Max(0, end - max); start < end; start += 1)
            {
                // s[..end] splits if s[..start] splits and s[start..end] is a word.
                if (dp[start] && words.Contains(s[start..end]))
                {
                    dp[end] = true;
                    // One valid split is enough.
                    break;
                }
            }
        }
        return dp[^1];
    }
}
