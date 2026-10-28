class ReferenceSolution:
    # O(n) time. A repeated remainder means a subarray divisible by k.
    def check_subarray_sum(self, nums: list[int], k: int) -> bool:
        first = {0: -1}
        total = 0
        for index, value in enumerate(nums):
            total += value
            remainder = total % k
            if remainder in first:
                if index - first[remainder] >= 2:
                    return True
            else:
                first[remainder] = index
        return False
