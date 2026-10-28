from solution import NumArray


class ReferenceSolution(NumArray):
    # O(n) build, O(1) queries. Store prefix sums so a range is one subtraction.
    def __init__(self, nums: list[int]) -> None:
        self.prefix = [0] * (len(nums) + 1)
        for index, value in enumerate(nums):
            self.prefix[index + 1] = self.prefix[index] + value

    def sum_range(self, left: int, right: int) -> int:
        return self.prefix[right + 1] - self.prefix[left]
