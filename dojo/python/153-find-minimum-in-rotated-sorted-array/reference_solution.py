class ReferenceSolution:
    # O(log n) time. The minimum is where the order breaks.
    def find_min(self, nums: list[int]) -> int:
        left, right = 0, len(nums) - 1
        while left < right:
            middle = (left + right) // 2
            if nums[middle] > nums[right]:
                left = middle + 1
            else:
                right = middle
        return nums[left]
