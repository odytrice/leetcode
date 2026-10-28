class ReferenceSolution:
    # O(n) time. Equal zeros and ones means a repeated running balance.
    def find_max_length(self, nums: list[int]) -> int:
        first = {0: -1}
        balance = best = 0
        for index, value in enumerate(nums):
            balance += 1 if value == 1 else -1
            if balance in first:
                best = max(best, index - first[balance])
            else:
                first[balance] = index
        return best
