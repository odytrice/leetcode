class ReferenceSolution:
    # O(n) time. Track the furthest reachable index.
    def can_jump(self, nums: list[int]) -> bool:
        reach = 0
        for index, value in enumerate(nums):
            if index > reach:
                return False
            reach = max(reach, index + value)
            if reach >= len(nums) - 1:
                return True
        return len(nums) <= 1
