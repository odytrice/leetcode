public class ReferenceSolution : Solution
{
    public override int LengthOfLIS(int[] nums)
    {
        var tails = new List<int>();
        foreach (int n in nums)
        {
            int l = 0, r = tails.Count;
            while (l < r) { int m = l + (r - l) / 2; if (tails[m] < n) l = m + 1; else r = m; }
            if (l == tails.Count) tails.Add(n); else tails[l] = n;
        }
        return tails.Count;
    }
}
