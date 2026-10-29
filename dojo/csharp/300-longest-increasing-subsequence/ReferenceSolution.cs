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
            // n is bigger than every tail, so it extends the longest run.
            if (l == tails.Count)
            {
                tails.Add(n);
            }
            else
            {
                // n is a smaller tail for runs of length l + 1, which leaves more room to grow.
                tails[l] = n;
            }
        }
        // tails is not itself a subsequence, but its length is the answer.
        return tails.Count;
    }
}
