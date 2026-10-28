public class ReferenceSolution
{
    // O(n) time and space, using frequency buckets.
    public int[] TopKFrequent(int[] nums, int k)
    {
        var counts = new Dictionary<int, int>();
        foreach (int n in nums) counts[n] = counts.GetValueOrDefault(n) + 1;
        var buckets = new List<int>?[nums.Length + 1];
        foreach (var (n, count) in counts) (buckets[count] ??= []).Add(n);
        var result = new List<int>();
        for (int f = nums.Length; f > 0 && result.Count < k; f--)
            if (buckets[f] is { } bucket) result.AddRange(bucket);
        return result.Take(k).ToArray();
    }
}
