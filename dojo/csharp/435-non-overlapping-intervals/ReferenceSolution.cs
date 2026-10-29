public class ReferenceSolution : Solution
{
    // O(n log n) time. Greedily keep the interval that ends first; remove the rest that overlap.
    public override int EraseOverlapIntervals(int[][] intervals)
    {
        Array.Sort(intervals, (a, b) => a[1].CompareTo(b[1]));
        // end is where the last kept interval finishes.
        int end = int.MinValue;
        int kept = 0;
        foreach (var interval in intervals)
        {
            // Touching at an endpoint is not an overlap, so >= keeps the interval.
            if (interval[0] >= end)
            {
                kept += 1;
                end = interval[1];
            }
        }
        // Everything not kept has to be removed.
        return intervals.Length - kept;
    }
}
