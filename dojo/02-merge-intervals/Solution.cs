public class Solution
{
    public int[][] Merge(int[][] intervals)
    {
        if (intervals.Length == 0) return [];

        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));
        var mergedGroups = new List<int[]>();
        int start = intervals[0][0];
        int end = intervals[0][1];

        for (int i = 1; i < intervals.Length; i++)
        {
            if (intervals[i][0] <= end)
            {
                // Extend the current group without shrinking it for contained intervals.
                end = Math.Max(end, intervals[i][1]);
            }
            else
            {
                // A gap closes the current group. Start a new one.
                mergedGroups.Add([start, end]);
                start = intervals[i][0];
                end = intervals[i][1];
            }
        }

        mergedGroups.Add([start, end]);
        return mergedGroups.ToArray();
    }
}
