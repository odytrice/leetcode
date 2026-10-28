class ReferenceSolution:
    # O(log n) time. Two lower-bound searches: one for the target, one past it.
    def search_range(self, nums: list[int], target: int) -> list[int]:
        def bound(upper: bool) -> int:
            left, right = 0, len(nums)
            while left < right:
                middle = (left + right) // 2
                if nums[middle] < target or (upper and nums[middle] == target):
                    left = middle + 1
                else:
                    right = middle
            return left

        first = bound(False)
        if first == len(nums) or nums[first] != target:
            return [-1, -1]
        return [first, bound(True) - 1]
