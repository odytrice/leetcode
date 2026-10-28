public class ReferenceSolution : Solution
{
    public override bool CheckInclusion(string s1, string s2)
    {
        if (s1.Length > s2.Length) return false;
        var need = new int[26]; var have = new int[26];
        foreach (char c in s1) need[c - 'a']++;
        for (int i = 0; i < s2.Length; i++)
        {
            have[s2[i] - 'a']++;
            if (i >= s1.Length) have[s2[i - s1.Length] - 'a']--;
            if (i >= s1.Length - 1 && have.SequenceEqual(need)) return true;
        }
        return false;
    }
}
