public class ReferenceSolution
{
    // O(n log n) time, O(n) output space. Sorts the input.
    public int[][] Merge(int[][] intervals)
    {
        // After sorting by start, overlapping intervals sit next to each other.
        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));
        var result = new List<int[]>();
        foreach (var interval in intervals)
        {
            // A gap starts a new interval; an overlap extends the last one.
            if (result.Count == 0 || result[^1][1] < interval[0])
            {
                result.Add([interval[0], interval[1]]);
            }
            else
            {
                // Max matters when the new interval lies entirely inside the last one.
                result[^1][1] = Math.Max(result[^1][1], interval[1]);
            }
        }
        return result.ToArray();
    }
}
