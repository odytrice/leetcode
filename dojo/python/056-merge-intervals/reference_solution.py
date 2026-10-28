class ReferenceSolution:
    # O(n log n) time. Sort by start, then extend or open a new interval.
    def merge(self, intervals: list[list[int]]) -> list[list[int]]:
        result: list[list[int]] = []
        for start, end in sorted(intervals):
            if result and result[-1][1] >= start:
                result[-1][1] = max(result[-1][1], end)
            else:
                result.append([start, end])
        return result
