class ReferenceSolution:
    # O(n) time. Each character's last position moves the window's left edge.
    def length_of_longest_substring(self, s: str) -> int:
        last: dict[str, int] = {}
        left = best = 0
        for right, char in enumerate(s):
            if char in last:
                left = max(left, last[char] + 1)
            last[char] = right
            best = max(best, right - left + 1)
        return best
