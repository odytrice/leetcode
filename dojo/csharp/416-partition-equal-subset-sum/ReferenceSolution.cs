public class ReferenceSolution : Solution
{
    public override bool CanPartition(int[] nums)
    {
        int sum = nums.Sum(); if (sum % 2 != 0) return false;
        int target = sum / 2; var dp = new bool[target + 1]; dp[0] = true;
        foreach (int n in nums) for (int t = target; t >= n; t--) dp[t] |= dp[t - n];
        return dp[target];
    }
}
