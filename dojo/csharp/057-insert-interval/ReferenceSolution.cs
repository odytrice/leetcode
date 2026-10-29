public class ReferenceSolution : Solution
{
    // O(n) time. Copy the intervals before, absorb the overlaps, then copy the rest.
    public override int[][] Insert(int[][] intervals, int[] newInterval)
    {
        var result = new List<int[]>();
        int i = 0;
        int start = newInterval[0];
        int end = newInterval[1];
        // Intervals that end before the new one starts are copied unchanged.
        while (i < intervals.Length && intervals[i][1] < start)
        {
            result.Add(intervals[i]);
            i += 1;
        }
        // Every interval that starts before the merged end overlaps it, so widen the merged range.
        while (i < intervals.Length && intervals[i][0] <= end)
        {
            start = Math.Min(start, intervals[i][0]);
            end = Math.Max(end, intervals[i][1]);
            i += 1;
        }
        // The merged interval goes in once, after all overlaps are absorbed.
        result.Add([start, end]);
        // The rest start after the merged interval ends.
        while (i < intervals.Length)
        {
            result.Add(intervals[i]);
            i += 1;
        }
        return result.ToArray();
    }
}
