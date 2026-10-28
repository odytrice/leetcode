class ReferenceSolution:
    # O(n) time, O(1) space. Move the wider end inward while the sum is wrong.
    def two_sum(self, numbers: list[int], target: int) -> list[int]:
        left, right = 0, len(numbers) - 1
        while left < right:
            total = numbers[left] + numbers[right]
            if total == target:
                return [left + 1, right + 1]
            if total < target:
                left += 1
            else:
                right -= 1
        raise ValueError("No answer")
