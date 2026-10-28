class ReferenceSolution:
    # O(n * n!) time. Build permutations by inserting each value at every position.
    def permute(self, nums: list[int]) -> list[list[int]]:
        result: list[list[int]] = [[]]
        for value in nums:
            next_result: list[list[int]] = []
            for permutation in result:
                for position in range(len(permutation) + 1):
                    next_result.append(permutation[:position] + [value] + permutation[position:])
            result = next_result
        return result
