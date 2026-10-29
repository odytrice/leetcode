import java.util.Arrays;

/** O(amount * len(coins)) time. dp[total] is the fewest coins for that total. */
class ReferenceSolution extends Solution {
    @Override
    public int coinChange(int[] coins, int amount) {
        // No answer can use more than amount coins, so amount + 1 safely means "impossible".
        int unreachable = amount + 1;
        int[] dp = new int[amount + 1];
        Arrays.fill(dp, unreachable);
        // Zero needs zero coins; every other total builds on it.
        dp[0] = 0;
        for (int total = 1; total <= amount; total += 1) {
            // Try each coin as the last one used to reach this total.
            for (int coin : coins) {
                if (coin <= total) {
                    dp[total] = Math.min(dp[total], dp[total - coin] + 1);
                }
            }
        }
        // Still at the sentinel means no combination works, which the problem reports as -1.
        return dp[amount] <= amount ? dp[amount] : -1;
    }
}
