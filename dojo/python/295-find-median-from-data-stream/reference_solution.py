import heapq

from solution import MedianFinder


class ReferenceSolution(MedianFinder):
    # O(log n) insertion, O(1) median. Two heaps keep the middle at the tops.
    def __init__(self) -> None:
        self.lower: list[int] = []
        self.upper: list[int] = []

    def add_num(self, num: int) -> None:
        heapq.heappush(self.lower, -num)
        heapq.heappush(self.upper, -heapq.heappop(self.lower))
        if len(self.upper) > len(self.lower):
            heapq.heappush(self.lower, -heapq.heappop(self.upper))

    def find_median(self) -> float:
        if len(self.lower) > len(self.upper):
            return float(-self.lower[0])
        return (-self.lower[0] + self.upper[0]) / 2
