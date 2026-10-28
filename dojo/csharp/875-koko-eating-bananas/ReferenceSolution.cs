public class ReferenceSolution : Solution
{
    public override int MinEatingSpeed(int[] piles, int h)
    {
        int l = 1, r = piles.Max();
        while (l < r)
        {
            int m = l + (r - l) / 2;
            long hours = 0;
            foreach (int pile in piles) hours += (pile + (long)m - 1) / m;
            if (hours <= h) r = m; else l = m + 1;
        }
        return l;
    }
}
