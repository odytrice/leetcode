from collections import Counter


class ReferenceSolution:
    # O(n) time. Bucket values by frequency, then read from the top.
    def top_k_frequent(self, nums: list[int], k: int) -> list[int]:
        counts = Counter(nums)
        buckets: list[list[int]] = [[] for _ in range(len(nums) + 1)]
        for value, count in counts.items():
            buckets[count].append(value)
        result: list[int] = []
        for count in range(len(nums), 0, -1):
            for value in buckets[count]:
                result.append(value)
                if len(result) == k:
                    return result
        return result
