class ReferenceSolution:
    # O(n) time and space. Remember each value's index before it is needed.
    def two_sum(self, nums: list[int], target: int) -> list[int]:
        seen: dict[int, int] = {}
        for index, value in enumerate(nums):
            partner = seen.get(target - value)
            if partner is not None:
                return [partner, index]
            seen[value] = index
        raise ValueError("No answer")
