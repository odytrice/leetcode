// O(amount * len(coins)) time. dp[total] is the fewest coins for that total.
export function coinChange(coins: number[], amount: number): number {
  const unreachable = amount + 1;
  const dp = new Array<number>(amount + 1).fill(unreachable);
  dp[0] = 0;
  for (let total = 1; total <= amount; total++) {
    for (const coin of coins) {
      if (coin <= total) dp[total] = Math.min(dp[total], dp[total - coin] + 1);
    }
  }
  return dp[amount] <= amount ? dp[amount] : -1;
}
