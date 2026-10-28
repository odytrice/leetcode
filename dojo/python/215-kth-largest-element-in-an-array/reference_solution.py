import heapq


class ReferenceSolution:
    # O(n log k) time. Keep a min-heap of the k largest values.
    def find_kth_largest(self, nums: list[int], k: int) -> int:
        heap = nums[:k]
        heapq.heapify(heap)
        for value in nums[k:]:
            if value > heap[0]:
                heapq.heapreplace(heap, value)
        return heap[0]
