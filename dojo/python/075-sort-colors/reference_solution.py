class ReferenceSolution:
    # O(n) time, O(1) space. Dutch national flag: grow the 0 and 2 regions inward.
    def sort_colors(self, nums: list[int]) -> None:
        low, index, high = 0, 0, len(nums) - 1
        while index <= high:
            if nums[index] == 0:
                nums[low], nums[index] = nums[index], nums[low]
                low += 1
                index += 1
            elif nums[index] == 2:
                nums[high], nums[index] = nums[index], nums[high]
                high -= 1
            else:
                index += 1
