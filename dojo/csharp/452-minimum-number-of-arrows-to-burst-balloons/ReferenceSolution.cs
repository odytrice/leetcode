public class ReferenceSolution : Solution
{
    public override int FindMinArrowShots(int[][] points)
    {
        Array.Sort(points, (a, b) => a[1].CompareTo(b[1])); int arrows = 0; long end = long.MinValue;
        foreach (var point in points) if (point[0] > end) { arrows++; end = point[1]; }
        return arrows;
    }
}
