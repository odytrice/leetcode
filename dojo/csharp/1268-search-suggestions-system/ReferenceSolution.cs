public class ReferenceSolution : Solution
{
    // O(n log n + m log n) time. Sort once, then binary search each prefix.
    public override IList<IList<string>> SuggestedProducts(string[] products, string searchWord)
    {
        Array.Sort(products, StringComparer.Ordinal);
        var result = new List<IList<string>>();
        for (int length = 1; length <= searchWord.Length; length += 1)
        {
            string prefix = searchWord[..length];

            // Find the first product that is not below the prefix.
            int l = 0;
            int r = products.Length;
            while (l < r)
            {
                int m = l + (r - l) / 2;
                if (string.CompareOrdinal(products[m], prefix) < 0)
                {
                    l = m + 1;
                }
                else
                {
                    r = m;
                }
            }

            // Up to three products from there that still start with the prefix.
            var suggestions = new List<string>();
            for (int i = l; i < products.Length && suggestions.Count < 3; i += 1)
            {
                if (!products[i].StartsWith(prefix, StringComparison.Ordinal))
                {
                    break;
                }
                suggestions.Add(products[i]);
            }
            result.Add(suggestions);
        }
        return result;
    }
}
