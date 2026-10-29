public class ReferenceSolution : Solution
{
    // O(n) time. Count 0 as -1; equal balances bound a subarray with as many 0s as 1s.
    public override int FindMaxLength(int[] nums)
    {
        // first maps each balance to the earliest index it appeared; balance 0 comes before index 0.
        var first = new Dictionary<int, int> { [0] = -1 };
        int balance = 0;
        int best = 0;
        for (int i = 0; i < nums.Length; i += 1)
        {
            balance += nums[i] == 0 ? -1 : 1;
            if (first.TryGetValue(balance, out int start))
            {
                // The same balance at start and i means nums[(start + 1)..i] is balanced.
                best = Math.Max(best, i - start);
            }
            else
            {
                // Only the first index is kept, since it gives the longest span later.
                first[balance] = i;
            }
        }
        return best;
    }
}
