public class ReferenceSolution : Solution
{
    public override int ShipWithinDays(int[] weights, int days)
    {
        int l = weights.Max(), r = weights.Sum();
        while (l < r)
        {
            int m = l + (r - l) / 2, used = 1, load = 0;
            foreach (int w in weights) { if (load + w > m) { used++; load = 0; } load += w; }
            if (used <= days) r = m; else l = m + 1;
        }
        return l;
    }
}
