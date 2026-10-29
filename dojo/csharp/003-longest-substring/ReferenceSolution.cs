public class ReferenceSolution
{
    // O(n) time, O(min(n, alphabet)) space.
    public int LengthOfLongestSubstring(string s)
    {
        var last = new Dictionary<char, int>();
        int left = 0;
        int best = 0;
        for (int right = 0; right < s.Length; right += 1)
        {
            // A repeat inside the window moves the left edge just past its earlier copy.
            if (last.TryGetValue(s[right], out int previous))
            {
                left = Math.Max(left, previous + 1);
            }
            last[s[right]] = right;
            best = Math.Max(best, right - left + 1);
        }
        return best;
    }
}
