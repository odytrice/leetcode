public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        var window = new HashSet<char>();
        int start = 0;
        int longestLength = 0;

        for (int end = 0; end < s.Length; end++)
        {
            char character = s[end];

            // Shrink from the left until adding this character cannot duplicate it.
            while (window.Contains(character))
            {
                window.Remove(s[start]);
                start++;
            }

            window.Add(character);
            longestLength = Math.Max(longestLength, end - start + 1);
        }

        return longestLength;
    }
}
