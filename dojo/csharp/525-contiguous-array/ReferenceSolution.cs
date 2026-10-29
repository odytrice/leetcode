public class ReferenceSolution : Solution
{
    // O(n) time. Count 0 as -1; equal balances bound a subarray with as many 0s as 1s.
    public override int FindMaxLength(int[] nums)
    {
        var first = new Dictionary<int, int> { [0] = -1 };
        int balance = 0;
        int best = 0;
        for (int i = 0; i < nums.Length; i += 1)
        {
            balance += nums[i] == 0 ? -1 : 1;
            if (first.TryGetValue(balance, out int start))
            {
                best = Math.Max(best, i - start);
            }
            else
            {
                first[balance] = i;
            }
        }
        return best;
    }
}
