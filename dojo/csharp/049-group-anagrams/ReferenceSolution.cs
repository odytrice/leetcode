public class ReferenceSolution : Solution
{
    public override IList<IList<string>> GroupAnagrams(string[] strs)
    {
        var groups = new Dictionary<string, IList<string>>();
        foreach (string word in strs)
        {
            var counts = new int[26];
            foreach (char c in word) counts[c - 'a']++;
            string key = string.Join(',', counts);
            if (!groups.TryGetValue(key, out var group)) groups[key] = group = new List<string>();
            group.Add(word);
        }
        return groups.Values.ToList();
    }
}
