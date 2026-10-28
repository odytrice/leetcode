class ReferenceSolution:
    # O(n) time and space. Count earlier prefixes whose difference is k.
    def subarray_sum(self, nums: list[int], k: int) -> int:
        counts = {0: 1}
        total = answer = 0
        for value in nums:
            total += value
            answer += counts.get(total - k, 0)
            counts[total] = counts.get(total, 0) + 1
        return answer
