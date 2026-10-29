public class ReferenceSolution : Solution
{
    // O(total characters) time. Letter counts identify each anagram group.
    public override IList<IList<string>> GroupAnagrams(string[] strs)
    {
        var groups = new Dictionary<string, IList<string>>();
        foreach (string word in strs)
        {
            var counts = new int[26];
            foreach (char c in word)
            {
                counts[c - 'a'] += 1;
            }
            string key = string.Join(',', counts);
            if (!groups.TryGetValue(key, out var group))
            {
                group = new List<string>();
                groups[key] = group;
            }
            group.Add(word);
        }
        return groups.Values.ToList();
    }
}
