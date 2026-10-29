public class ReferenceSolution : Solution
{
    // O(n log total) time. Binary search the smallest capacity that ships in time.
    public override int ShipWithinDays(int[] weights, int days)
    {
        int l = weights.Max();
        int r = weights.Sum();
        while (l < r)
        {
            int m = l + (r - l) / 2;
            int used = 1;
            int load = 0;
            foreach (int w in weights)
            {
                // Start a new day when this package would overload the current one.
                if (load + w > m)
                {
                    used += 1;
                    load = 0;
                }
                load += w;
            }
            if (used <= days)
            {
                r = m;
            }
            else
            {
                l = m + 1;
            }
        }
        return l;
    }
}
