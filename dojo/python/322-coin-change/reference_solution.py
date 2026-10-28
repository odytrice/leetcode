class ReferenceSolution:
    # O(amount * len(coins)) time. dp[total] is the fewest coins for that total.
    def coin_change(self, coins: list[int], amount: int) -> int:
        unreachable = amount + 1
        dp = [unreachable] * (amount + 1)
        dp[0] = 0
        for total in range(1, amount + 1):
            for coin in coins:
                if coin <= total:
                    dp[total] = min(dp[total], dp[total - coin] + 1)
        return dp[amount] if dp[amount] <= amount else -1
