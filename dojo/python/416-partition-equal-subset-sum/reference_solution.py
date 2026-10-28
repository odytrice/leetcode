class ReferenceSolution:
    # O(n * sum) time, O(sum) space. Descending totals prevent reusing one number.
    def can_partition(self, nums: list[int]) -> bool:
        total = sum(nums)
        if total % 2 != 0:
            return False
        target = total // 2
        reachable = [False] * (target + 1)
        reachable[0] = True
        for value in nums:
            for subtotal in range(target, value - 1, -1):
                if reachable[subtotal - value]:
                    reachable[subtotal] = True
        return reachable[target]
