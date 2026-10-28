class ReferenceSolution:
    # O(n) time. The window may hold at most k zeros.
    def longest_ones(self, nums: list[int], k: int) -> int:
        left = zeros = best = 0
        for right, value in enumerate(nums):
            if value == 0:
                zeros += 1
            while zeros > k:
                if nums[left] == 0:
                    zeros -= 1
                left += 1
            best = max(best, right - left + 1)
        return best
