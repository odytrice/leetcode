class ReferenceSolution:
    # O(n) time, O(1) space. Each house either skips or adds to the total two back.
    def rob(self, nums: list[int]) -> int:
        previous = best = 0
        for value in nums:
            previous, best = best, max(best, previous + value)
        return best
