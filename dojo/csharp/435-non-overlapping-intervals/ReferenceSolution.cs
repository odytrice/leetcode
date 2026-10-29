public class ReferenceSolution : Solution
{
    // O(n log n) time. Greedily keep the interval that ends first; remove the rest that overlap.
    public override int EraseOverlapIntervals(int[][] intervals)
    {
        Array.Sort(intervals, (a, b) => a[1].CompareTo(b[1]));
        int end = int.MinValue;
        int kept = 0;
        foreach (var interval in intervals)
        {
            if (interval[0] >= end)
            {
                kept += 1;
                end = interval[1];
            }
        }
        return intervals.Length - kept;
    }
}
