public class ReferenceSolution : Solution
{
    // O(n * sum) time. dp[t] is true when some subset sums to t.
    public override bool CanPartition(int[] nums)
    {
        int sum = nums.Sum();
        // An odd total cannot split into two equal halves.
        if (sum % 2 != 0)
        {
            return false;
        }
        int target = sum / 2;
        var dp = new bool[target + 1];
        // The empty subset sums to 0.
        dp[0] = true;
        foreach (int n in nums)
        {
            // Go downward so each value is used at most once.
            for (int t = target; t >= n; t -= 1)
            {
                dp[t] |= dp[t - n];
            }
        }
        // A subset with half the total leaves the other half for the rest.
        return dp[target];
    }
}
