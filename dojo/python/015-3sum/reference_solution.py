class ReferenceSolution:
    # O(n^2) time, O(1) extra space beyond the output. Sort, then fix one value.
    def three_sum(self, nums: list[int]) -> list[list[int]]:
        nums = sorted(nums)
        result: list[list[int]] = []
        for first in range(len(nums) - 2):
            if first > 0 and nums[first] == nums[first - 1]:
                continue
            left, right = first + 1, len(nums) - 1
            while left < right:
                total = nums[first] + nums[left] + nums[right]
                if total < 0:
                    left += 1
                elif total > 0:
                    right -= 1
                else:
                    result.append([nums[first], nums[left], nums[right]])
                    left_value, right_value = nums[left], nums[right]
                    while left < right and nums[left] == left_value:
                        left += 1
                    while left < right and nums[right] == right_value:
                        right -= 1
        return result
