public class ReferenceSolution
{
    // O(n) time and space, using frequency buckets.
    public int[] TopKFrequent(int[] nums, int k)
    {
        // counts[n] is how many times n appears.
        var counts = new Dictionary<int, int>();
        foreach (int n in nums)
        {
            counts[n] = counts.GetValueOrDefault(n) + 1;
        }

        // buckets[f] holds the values that appear exactly f times.
        var buckets = new List<int>?[nums.Length + 1];
        foreach (var (n, count) in counts)
        {
            (buckets[count] ??= []).Add(n);
        }

        // Walk from the highest frequency down until k values are collected.
        var result = new List<int>();
        for (int f = nums.Length; f > 0 && result.Count < k; f -= 1)
        {
            if (buckets[f] is { } bucket)
            {
                result.AddRange(bucket);
            }
        }
        // The last bucket may overshoot k, so trim the extra values.
        return result.Take(k).ToArray();
    }
}
