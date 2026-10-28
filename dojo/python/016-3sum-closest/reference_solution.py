class ReferenceSolution:
    # O(n^2) time. Sort, then shrink the gap with two pointers.
    def three_sum_closest(self, nums: list[int], target: int) -> int:
        nums = sorted(nums)
        best = nums[0] + nums[1] + nums[2]
        for first in range(len(nums) - 2):
            left, right = first + 1, len(nums) - 1
            while left < right:
                total = nums[first] + nums[left] + nums[right]
                if abs(total - target) < abs(best - target):
                    best = total
                if total == target:
                    return total
                if total < target:
                    left += 1
                else:
                    right -= 1
        return best
