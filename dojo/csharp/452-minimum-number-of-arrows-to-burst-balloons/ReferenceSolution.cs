public class ReferenceSolution : Solution
{
    // O(n log n) time. Shoot at the earliest end; it bursts every balloon that started before it.
    public override int FindMinArrowShots(int[][] points)
    {
        Array.Sort(points, (a, b) => a[1].CompareTo(b[1]));
        int arrows = 0;
        // end is where the current arrow is shot; long.MinValue means no arrow yet.
        long end = long.MinValue;
        foreach (var point in points)
        {
            // This balloon starts after the arrow, so it needs a new arrow at its own end.
            if (point[0] > end)
            {
                arrows += 1;
                end = point[1];
            }
        }
        return arrows;
    }
}
