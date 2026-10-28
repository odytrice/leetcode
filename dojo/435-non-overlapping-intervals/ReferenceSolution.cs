public class ReferenceSolution : Solution
{
    public override int EraseOverlapIntervals(int[][] intervals)
    {
        Array.Sort(intervals, (a, b) => a[1].CompareTo(b[1])); int end = int.MinValue, kept = 0;
        foreach (var interval in intervals) if (interval[0] >= end) { kept++; end = interval[1]; }
        return intervals.Length - kept;
    }
}
