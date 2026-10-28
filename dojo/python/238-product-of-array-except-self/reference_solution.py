class ReferenceSolution:
    # O(n) time, O(1) extra space. Write prefixes, then multiply suffixes.
    def product_except_self(self, nums: list[int]) -> list[int]:
        result = [1] * len(nums)
        prefix = suffix = 1
        for index, value in enumerate(nums):
            result[index] = prefix
            prefix *= value
        for index in range(len(nums) - 1, -1, -1):
            result[index] *= suffix
            suffix *= nums[index]
        return result
