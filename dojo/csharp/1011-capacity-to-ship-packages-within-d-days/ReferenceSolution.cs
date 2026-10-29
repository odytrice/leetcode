public class ReferenceSolution : Solution
{
    // O(n log total) time. Binary search the smallest capacity that ships in time.
    public override int ShipWithinDays(int[] weights, int days)
    {
        // The capacity must fit the heaviest package and never needs more than the total weight.
        int l = weights.Max();
        int r = weights.Sum();
        while (l < r)
        {
            int m = l + (r - l) / 2;
            // Load packages greedily with capacity m and count the days used.
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
            // m works, so try smaller; otherwise more capacity is needed.
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
