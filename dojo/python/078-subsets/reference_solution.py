class ReferenceSolution:
    # O(n * 2^n) time. Each value doubles the result set by extending every subset.
    def subsets(self, nums: list[int]) -> list[list[int]]:
        result: list[list[int]] = [[]]
        for value in nums:
            result += [subset + [value] for subset in result]
        return result
