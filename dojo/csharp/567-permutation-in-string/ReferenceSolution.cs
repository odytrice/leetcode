public class ReferenceSolution : Solution
{
    // O(26 * n) time. Slide a window of s1's length and compare letter counts.
    public override bool CheckInclusion(string s1, string s2)
    {
        if (s1.Length > s2.Length)
        {
            return false;
        }
        var need = new int[26];
        var have = new int[26];
        foreach (char c in s1)
        {
            need[c - 'a'] += 1;
        }
        for (int i = 0; i < s2.Length; i += 1)
        {
            have[s2[i] - 'a'] += 1;
            // Drop the letter that just left the window.
            if (i >= s1.Length)
            {
                have[s2[i - s1.Length] - 'a'] -= 1;
            }
            if (i >= s1.Length - 1 && have.SequenceEqual(need))
            {
                return true;
            }
        }
        return false;
    }
}
