// O(amount * len(coins)) time. dp[total] is the fewest coins for that total.
export function coinChange(coins: number[], amount: number): number {
  // amount + 1 coins is more than any real answer, so it marks a total as unreachable.
  const unreachable = amount + 1;
  const dp = new Array<number>(amount + 1).fill(unreachable);
  dp[0] = 0;
  for (let total = 1; total <= amount; total += 1) {
    for (const coin of coins) {
      if (coin <= total) {
        // Use this coin last: one coin plus the best way to make the rest.
        dp[total] = Math.min(dp[total], dp[total - coin] + 1);
      }
    }
  }
  // A value above amount means the sentinel survived and the amount cannot be made.
  return dp[amount] <= amount ? dp[amount] : -1;
}
