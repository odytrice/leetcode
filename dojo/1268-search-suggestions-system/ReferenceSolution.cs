public class ReferenceSolution : Solution
{
    public override IList<IList<string>> SuggestedProducts(string[] products, string searchWord)
    {
        Array.Sort(products, StringComparer.Ordinal); var result = new List<IList<string>>();
        for (int length = 1; length <= searchWord.Length; length++)
        {
            string prefix = searchWord[..length]; int l = 0, r = products.Length;
            while (l < r) { int m = l + (r - l) / 2; if (string.CompareOrdinal(products[m], prefix) < 0) l = m + 1; else r = m; }
            var suggestions = new List<string>();
            for (int i = l; i < products.Length && suggestions.Count < 3 && products[i].StartsWith(prefix, StringComparison.Ordinal); i++) suggestions.Add(products[i]);
            result.Add(suggestions);
        }
        return result;
    }
}
