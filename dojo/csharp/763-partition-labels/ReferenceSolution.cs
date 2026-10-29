public class ReferenceSolution : Solution
{
    // O(n) time. A part can close once it reaches the last occurrence of every letter in it.
    public override IList<int> PartitionLabels(string s)
    {
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
            end = Math.Max(end, last[s[i] - 'a']);
            if (i == end)
            {
                result.Add(end - start + 1);
                start = i + 1;
            }
        }
        return result;
    }
}
