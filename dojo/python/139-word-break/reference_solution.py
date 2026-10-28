class ReferenceSolution:
    # O(n * max word length) time. dp[i] is true when s[:i] can be segmented.
    def word_break(self, s: str, word_dict: list[str]) -> bool:
        words = set(word_dict)
        longest = max((len(word) for word in word_dict), default=0)
        dp = [False] * (len(s) + 1)
        dp[0] = True
        for end in range(1, len(s) + 1):
            for start in range(max(0, end - longest), end):
                if dp[start] and s[start:end] in words:
                    dp[end] = True
                    break
        return dp[-1]
