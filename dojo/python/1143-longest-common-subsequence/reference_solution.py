class ReferenceSolution:
    # O(len1 * len2) time, O(len2) space. Keep one row and the diagonal.
    def longest_common_subsequence(self, text1: str, text2: str) -> int:
        dp = [0] * (len(text2) + 1)
        for first in text1:
            diagonal = 0
            for column in range(1, len(text2) + 1):
                previous = dp[column]
                if first == text2[column - 1]:
                    dp[column] = diagonal + 1
                else:
                    dp[column] = max(dp[column], dp[column - 1])
                diagonal = previous
        return dp[-1]
