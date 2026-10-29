public class ReferenceSolution : Solution
{
    // O(n) time. A window is valid when replacing all but its most common letter costs at most k.
    public override int CharacterReplacement(string s, int k)
    {
        var counts = new int[26];
        int left = 0;
        int maxCount = 0;
        int best = 0;
        for (int right = 0; right < s.Length; right += 1)
        {
            counts[s[right] - 'A'] += 1;
            maxCount = Math.Max(maxCount, counts[s[right] - 'A']);
            while (right - left + 1 - maxCount > k)
            {
                counts[s[left] - 'A'] -= 1;
                left += 1;
            }
            best = Math.Max(best, right - left + 1);
        }
        return best;
    }
}
