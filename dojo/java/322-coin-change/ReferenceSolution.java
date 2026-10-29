import java.util.Arrays;

/** O(amount * len(coins)) time. dp[total] is the fewest coins for that total. */
class ReferenceSolution extends Solution {
    @Override
    public int coinChange(int[] coins, int amount) {
        int unreachable = amount + 1;
        int[] dp = new int[amount + 1];
        Arrays.fill(dp, unreachable);
        dp[0] = 0;
        for (int total = 1; total <= amount; total += 1) {
            for (int coin : coins) {
                if (coin <= total) {
                    dp[total] = Math.min(dp[total], dp[total - coin] + 1);
                }
            }
        }
        return dp[amount] <= amount ? dp[amount] : -1;
    }
}
