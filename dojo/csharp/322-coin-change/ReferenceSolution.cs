public class ReferenceSolution : Solution
{
    // O(amount * coins) time. dp[sum] is the fewest coins that make sum; amount + 1 means impossible.
    public override int CoinChange(int[] coins, int amount)
    {
        var dp = Enumerable.Repeat(amount + 1, amount + 1).ToArray();
        // Zero coins make a sum of zero.
        dp[0] = 0;
        for (int sum = 1; sum <= amount; sum += 1)
        {
            foreach (int coin in coins)
            {
                // Try this coin as the last one: one coin plus the best way to make the rest.
                if (coin <= sum)
                {
                    dp[sum] = Math.Min(dp[sum], dp[sum - coin] + 1);
                }
            }
        }
        // A value above amount was never improved, so the sum cannot be made.
        return dp[amount] > amount ? -1 : dp[amount];
    }
}
