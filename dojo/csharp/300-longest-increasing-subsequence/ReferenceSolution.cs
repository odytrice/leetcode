public class ReferenceSolution : Solution
{
    // O(n log n) time. tails[i] is the smallest tail of any increasing run of length i + 1.
    public override int LengthOfLIS(int[] nums)
    {
        var tails = new List<int>();
        foreach (int n in nums)
        {
            // Find the first tail that is not below n.
            int l = 0;
            int r = tails.Count;
            while (l < r)
            {
                int m = l + (r - l) / 2;
                if (tails[m] < n)
                {
                    l = m + 1;
                }
                else
                {
                    r = m;
                }
            }
            if (l == tails.Count)
            {
                tails.Add(n);
            }
            else
            {
                tails[l] = n;
            }
        }
        return tails.Count;
    }
}
