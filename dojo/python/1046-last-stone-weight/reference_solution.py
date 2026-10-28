import heapq


class ReferenceSolution:
    # O(n log n) time. Always smash the two heaviest stones.
    def last_stone_weight(self, stones: list[int]) -> int:
        heap = [-stone for stone in stones]
        heapq.heapify(heap)
        while len(heap) > 1:
            first = -heapq.heappop(heap)
            second = -heapq.heappop(heap)
            if first != second:
                heapq.heappush(heap, -(first - second))
        return -heap[0] if heap else 0
