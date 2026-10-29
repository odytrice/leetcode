public class ReferenceSolution : Solution
{
    // O(n log max) time. Binary search the slowest speed that finishes within h hours.
    public override int MinEatingSpeed(int[] piles, int h)
    {
        int l = 1;
        int r = piles.Max();
        while (l < r)
        {
            int m = l + (r - l) / 2;
            long hours = 0;
            foreach (int pile in piles)
            {
                // Ceiling division: a partly eaten pile still takes a full hour.
                hours += (pile + (long)m - 1) / m;
            }
            if (hours <= h)
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
