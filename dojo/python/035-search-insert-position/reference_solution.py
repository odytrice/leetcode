class ReferenceSolution:
    # O(log n) time. Find the first index whose value is not below the target.
    def search_insert(self, nums: list[int], target: int) -> int:
        left, right = 0, len(nums)
        while left < right:
            middle = (left + right) // 2
            if nums[middle] < target:
                left = middle + 1
            else:
                right = middle
        return left
