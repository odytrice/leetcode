class ReferenceSolution:
    # O(n log n) time. Greedily keep the interval that ends earliest.
    def erase_overlap_intervals(self, intervals: list[list[int]]) -> int:
        end = float("-inf")
        kept = 0
        for start, finish in sorted(intervals, key=lambda interval: interval[1]):
            if start >= end:
                kept += 1
                end = finish
        return len(intervals) - kept
