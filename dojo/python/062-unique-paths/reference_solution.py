class ReferenceSolution:
    # O(m * n) time, O(n) space. Each cell adds its left and above neighbours.
    def unique_paths(self, m: int, n: int) -> int:
        dp = [1] * n
        for _ in range(1, m):
            for column in range(1, n):
                dp[column] += dp[column - 1]
        return dp[-1]
