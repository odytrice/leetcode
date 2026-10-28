public class ReferenceSolution : Solution
{
    public override int CharacterReplacement(string s, int k)
    {
        var counts = new int[26];
        int left = 0, maxCount = 0, best = 0;
        for (int right = 0; right < s.Length; right++)
        {
            maxCount = Math.Max(maxCount, ++counts[s[right] - 'A']);
            while (right - left + 1 - maxCount > k) counts[s[left++] - 'A']--;
            best = Math.Max(best, right - left + 1);
        }
        return best;
    }
}
