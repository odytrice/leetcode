class ReferenceSolution:
    # O(n) time. A window is valid when everything but its most common letter fits in k.
    def character_replacement(self, s: str, k: int) -> int:
        counts: dict[str, int] = {}
        left = best = most = 0
        for right, char in enumerate(s):
            counts[char] = counts.get(char, 0) + 1
            most = max(most, counts[char])
            while right - left + 1 - most > k:
                counts[s[left]] -= 1
                left += 1
            best = max(best, right - left + 1)
        return best
