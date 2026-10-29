public class ReferenceSolution : Solution
{
    // O(amount * coins) time. dp[sum] is the fewest coins that make sum; amount + 1 means impossible.
    public override int CoinChange(int[] coins, int amount)
    {
        var dp = Enumerable.Repeat(amount + 1, amount + 1).ToArray();
        dp[0] = 0;
        for (int sum = 1; sum <= amount; sum += 1)
        {
            foreach (int coin in coins)
            {
                if (coin <= sum)
                {
                    dp[sum] = Math.Min(dp[sum], dp[sum - coin] + 1);
                }
            }
        }
        return dp[amount] > amount ? -1 : dp[amount];
    }
}
