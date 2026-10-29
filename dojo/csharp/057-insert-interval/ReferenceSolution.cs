public class ReferenceSolution : Solution
{
    // O(n) time. Copy the intervals before, absorb the overlaps, then copy the rest.
    public override int[][] Insert(int[][] intervals, int[] newInterval)
    {
        var result = new List<int[]>();
        int i = 0;
        int start = newInterval[0];
        int end = newInterval[1];
        while (i < intervals.Length && intervals[i][1] < start)
        {
            result.Add(intervals[i]);
            i += 1;
        }
        while (i < intervals.Length && intervals[i][0] <= end)
        {
            start = Math.Min(start, intervals[i][0]);
            end = Math.Max(end, intervals[i][1]);
            i += 1;
        }
        result.Add([start, end]);
        while (i < intervals.Length)
        {
            result.Add(intervals[i]);
            i += 1;
        }
        return result.ToArray();
    }
}
