public class ReferenceSolution : Solution
{
    // O(n) time. A part can close once it reaches the last occurrence of every letter in it.
    public override IList<int> PartitionLabels(string s)
    {
        // last[c] is the final index where letter c appears.
        var last = new int[26];
        for (int i = 0; i < s.Length; i += 1)
        {
            last[s[i] - 'a'] = i;
        }
        var result = new List<int>();
        int start = 0;
        int end = 0;
        for (int i = 0; i < s.Length; i += 1)
        {
            // The part must stretch at least to the last copy of every letter it holds.
            end = Math.Max(end, last[s[i] - 'a']);
            // No letter in the part appears later, so it can close here.
            if (i == end)
            {
                result.Add(end - start + 1);
                start = i + 1;
            }
        }
        return result;
    }
}
